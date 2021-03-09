using Core.Utilities.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using TheWayShop.Business.Abstract;
using TheWayShop.Model.Entity;
using TheWayShop.Model.Enums;
using TheWayShop.Model.StaticValues;
using TheWayShop.Model.ViewModels.AdminPanel;
using TheWayShop.MVCUI.Aspects;
using TheWayShop.MVCUI.Extensions;

namespace TheWayShop.MVCUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class AdminController : Controller
    {
        private readonly IAdminBs _adminBs;
        private readonly IRoleBs _roleBs;


        public AdminController(IAdminBs adminBs, IRoleBs roleBs)
        {
            _adminBs = adminBs;
            _roleBs = roleBs;
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            string userNameCookie = Request.Cookies[MagicStrings.UN_COOKIE_NAME];
            string passwordCookie = Request.Cookies[MagicStrings.PW_COOKIE_NAME];

            if (!(string.IsNullOrEmpty(userNameCookie) && string.IsNullOrEmpty(passwordCookie)))
            {
                ViewData["un"] = HashHelper.AESDecrypt(userNameCookie, MagicStrings.AES_HASH_KEY);
                ViewData["pw"] = HashHelper.AESDecrypt(passwordCookie, MagicStrings.AES_HASH_KEY);
                ViewData["isChecked"] = true;
            }

            return View();
        }

        [HttpPost]
        public IActionResult LogIn(LoginVm vm)
        {
            Admin admin = _adminBs.LogIn(vm.Email, HashHelper.AESEncrypt(vm.Password, MagicStrings.AES_HASH_KEY), "Role");

            if (admin != null&&admin.IsActive!=false)
            {
                HttpContext.Session.SetObject(MagicStrings.SESSION_ACTIVE_ADMIN, admin);

                if (vm.RememberMe)
                {

                    Response.Cookies.Append(MagicStrings.UN_COOKIE_NAME, HashHelper.AESEncrypt(vm.Email, MagicStrings.AES_HASH_KEY));
                    Response.Cookies.Append(MagicStrings.PW_COOKIE_NAME, HashHelper.AESEncrypt(vm.Password, MagicStrings.AES_HASH_KEY));
                }
                else
                {
                    Response.Cookies.Delete(MagicStrings.UN_COOKIE_NAME);
                    Response.Cookies.Delete(MagicStrings.PW_COOKIE_NAME);
                }


                return Json(new { Result = true });
            }


            return Json(new { Result = false, Message = "Yönetici Bulunamadı" });



        }

        [HttpPost]
        public IActionResult ForgotPassword(string email)
        {
            Admin admin = _adminBs.AdminByEmail(email);
            if (admin != null)
            {
                string newPassword = RandomValueGenerator.GeneratePassword(8);

                admin.Password = HashHelper.AESEncrypt(newPassword, MagicStrings.AES_HASH_KEY);
                _adminBs.Update(admin);

                string mailMessage = $"Sayın {admin.FullName} <br /> Yeni Şifreniz : <b>{newPassword}</b>";

                MailSender.Send(email, "Yeni Şifre", mailMessage);

                return Json(new { Result = true, Message = "Mailinize şifre gönderildi" });
            }


            return Json(new { Result = false, Message = "Bu email adresine sahip bir yönetici bulunamadı. Tekrar deneyiniz" });

        }

        [HttpGet]
        [SessionAspect]
        public IActionResult LogOut()
        {
            HttpContext.Session.Remove(MagicStrings.SESSION_ACTIVE_ADMIN); // key kullanarak kaldırma

            HttpContext.Session.Clear(); // tümünü kaldırma

            return View("LogIn");
        }

        [HttpGet]
        [SessionAspect]
        [RoleAspect((int)AdminRoles.SuperAdmin)]
        public IActionResult List()
        {
           
            AdminListVm vm = new AdminListVm();
            
            vm.Admins = _adminBs.AdminList();
            vm.Roles = _roleBs.RoleList().Select(x => new SelectListItem()
            {
                Text = x.RoleName,
                Value = x.Id.ToString()
            }).ToList();

            vm.Roles.Insert(0, new SelectListItem() { Text = "Seçiniz...", Value = "-1" });

            return View(vm);
        }

        [SessionAspect]
        [HttpPost]
        [RoleAspect((int)AdminRoles.SuperAdmin)]
        public IActionResult PhotoUpload()
        {
            IFormFileCollection files = Request.Form.Files;

            if (files.Count > 0)
            {
                if (!files[0].ContentType.StartsWith("image/"))
                    return Json(new { Result = false, Message = "Lütfen sadece resim dosya seçiniz" });

                if (files[0].Length > (100 * 1024))
                    return Json(new { Result = false, Message = "Lütfen 100 KB dan küçük dosya seçiniz" });

                var originalFileName = files[0].FileName;
                var generatedFileName = RandomValueGenerator.GenerateFileName(Path.GetExtension(originalFileName));


                var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AdminPanel/img/AdminPhotos", generatedFileName);

                using (var fileStream = new FileStream(uploadPath, FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }

                return Json(new { Result = true, PhotoPath = "/AdminPanel/img/AdminPhotos/" + generatedFileName });
            }
            else
                return Json(new { Result = false, Message = "Lütfen dosya seçiniz" });


        }

        [HttpPost]
        [SessionAspect]
        public IActionResult New(NewAdminVm vm)
        {
            if (!ModelState.IsValid)
            {
                string errorMessages = "";

                foreach (var value in ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        errorMessages += error.ErrorMessage + "<br />";
                    }
                }

                return Json(new { Result = false, Message = errorMessages });
            }

            Admin admin = new Admin();
            admin.Email = vm.Email;
            admin.FullName = vm.FullName;
            admin.IsActive = vm.IsActive.Value;
            admin.Password = HashHelper.AESEncrypt(vm.Password, MagicStrings.AES_HASH_KEY);
            admin.Photo = vm.Photo;
            admin.RoleId = vm.RoleId;

            _adminBs.Insert(admin);

            return Json(new { Result = true, Message = "Yönetici Başarıyla Kaydedildi" });

        }

        [HttpPost]
        [SessionAspect]
        public IActionResult DetailsById(int id)
        {
            Admin admin = _adminBs.AdminById(id);

            AdminDetailsVm vm = new AdminDetailsVm();
            vm.Email = admin.Email;
            vm.FullName = admin.FullName;
            vm.Id = admin.Id;
            vm.Password = HashHelper.AESDecrypt(admin.Password,MagicStrings.AES_HASH_KEY);
            vm.Photo = admin.Photo;
            vm.RoleId = admin.RoleId;
            vm.IsActive = admin.IsActive;

            return Json(new { AdminInfo = vm });

        }
        [SessionAspect]
        [HttpPost]
        public IActionResult PhotoUpdate()
        {
            IFormFileCollection files = Request.Form.Files;

            if (files.Count > 0)
            {
                if (!files[0].ContentType.StartsWith("image/"))
                {
                    return Json(new { Result = false, Message = "Lütfen Resim Dosyası Seiçiniz." });
                }
                if (files[0].Length > (100 * 1024))
                {
                    return Json(new { Result = false, Message = "Lütfen 100KB den Küçük Dosya Seçiniz." });
                }

                var orginalFileName = files[0].FileName;
                var generatedFileName = RandomValueGenerator.GenerateFileName(Path.GetExtension(orginalFileName));

                var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AdminPanel/img/AdminPhotos", generatedFileName);

                using (var fileStream = new FileStream(uploadPath, FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                return Json(new { Result = true, PhotoPath = "/AdminPanel/img/AdminPhotos/" + generatedFileName });
            }
            else
            {
                return Json(new { Result = false, Message = "Lütfen Dosya Seçiniz" });
            }
        }

        [HttpPost]
        [SessionAspect]
        [RoleAspect((int)AdminRoles.SuperAdmin)]
        public IActionResult Update(AdminUpdateVm vm)
        {
            if (!ModelState.IsValid)
            {
                string errorMessages = "";

                foreach (var value in ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        errorMessages += error.ErrorMessage + "<br />";
                    }
                }

                return Json(new { Result = false, Message = errorMessages });
            }
            Admin admin = _adminBs.AdminById(vm.Id);

            admin.Email = vm.Email;
            admin.FullName = vm.FullName;
            admin.IsActive = vm.IsActive.Value;
            admin.Password = HashHelper.AESEncrypt(vm.Password, MagicStrings.AES_HASH_KEY);
            admin.RoleId = vm.RoleId;
            admin.Photo = vm.Photo;
            _adminBs.Update(admin);

            return Json(new {Result=true,Message="Yönetici başarıyla güncellendi" });

            
        }
        //[HttpPost]
        //[SessionAspect]
        //[RoleAspect((int)AdminRoles.SuperAdmin)]
        //public IActionResult Delete(int adminId)
        //{
        //    _adminBs.Delete(adminId);

        //    return Json(new { Result = true, Message = "Yönetici Başarıyla Silindi" });


        //}
        [HttpPost]
        [SessionAspect]
        [RoleAspect((int)AdminRoles.SuperAdmin)]
        public IActionResult Delete(int adminId)
        {
            _adminBs.DeleteNoActive(adminId);

            return Json(new { Result = true, Message = "Yönetici Başarıyla Silindi" });
        }
    }
}


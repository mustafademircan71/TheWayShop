using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Common;
using Microsoft.AspNetCore.Mvc;
using TheWayShop.Business.Abstract;
using TheWayShop.Model.Entity;
using TheWayShop.Model.StaticValues;
using TheWayShop.Model.ViewModels.Shop;
using TheWayShop.MVCUI.Aspects;
using TheWayShop.MVCUI.Extensions;

namespace TheWayShop.MVCUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserBs _userBs;
        private readonly ICreditCartBs _creditCartBs;

        public UserController(IUserBs userBs, ICreditCartBs creditCartBs)
        {
            _userBs = userBs;
            _creditCartBs = creditCartBs;
        }

        [HttpGet]
        public IActionResult LogIn()
        {
         
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(UserLogInVm vm)
        {
            User user = _userBs.LogIn(vm.Email, HashHelper.AESEncrypt(vm.Password, MagicStrings.AES_HASH_KEY));

            if (user != null&&user.IsActive!=false)
            {
               
                HttpContext.Session.SetObject(MagicStrings.SESSION_ACTIVE_USER, user);
                return Json(new { Result = true });
            }

            return Json(new { Result = false, Message = "Kullanıcı Bulunamadı" });
        }

        [HttpPost]
        public IActionResult ForgotPassword(string email)
        {
            User user = _userBs.UserByEmail(email);
            if (user != null)
            {
                string newPassword = RandomValueGenerator.GeneratePassword(8);

                user.Password = HashHelper.AESEncrypt(newPassword, MagicStrings.AES_HASH_KEY);
                _userBs.Update(user);

                string mailMessage = $"Sayın {user.FullName} <br /> Yeni Şifreniz : <b>{newPassword}</b>";

                MailSender.Send(email, "Yeni Şifre", mailMessage);

                return Json(new { Result = true, Message = "Mailinize şifre gönderildi" });
            }


            return Json(new { Result = false, Message = "Bu email adresine sahip bir yönetici bulunamadı. Tekrar deneyiniz" });

        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Remove(MagicStrings.SESSION_ACTIVE_USER); 

            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }

        [UserSessionAspect]
        public IActionResult MyAccount()
        {
            return View();
        }
        public IActionResult NewUser(NewUserVm vm)
        {
            User user = new User();
            user.IsActive = true;
            user.FullName = vm.FullName;
            user.Email = vm.Email;
            user.Password = HashHelper.AESEncrypt(vm.Password, MagicStrings.AES_HASH_KEY);
            _userBs.Insert(user);

            return Json(new { Result = true, Message = "Kullanıcı Kayıt Edildi." });

        }
        [UserSessionAspect]
        public IActionResult MyProfile()
        {
            UserDetailsVm vm = new UserDetailsVm();
           

            return View(vm.user);
        }
        [UserSessionAspect]
        [HttpPost]
        public IActionResult UserUpdate(UserUpdateVm vm)
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
            User user = _userBs.UserById(vm.Id);

            user.Id = vm.Id;
            user.FullName = vm.FullName;
            user.Email = vm.Email;
            user.City = vm.City;
            user.Country = vm.Country;
            user.Adress = vm.Adress;
            user.Phone = vm.Phone;
            _userBs.Update(user);
            return Json(new { Result = true, Message = "Bilgileriniz Güncellendi" });

        }
        [UserSessionAspect]
        public IActionResult UserCreditCartList(int userId)
        {
            List<CreditCart> creditCarts = _creditCartBs.CreditCartByUserList(userId);

            return View(creditCarts);
           
        }
        [UserSessionAspect]
        [HttpPost]
        public IActionResult UserCreditCartInsert(CreditCartInsertVm vm)
        {
            CreditCart creditCart = new CreditCart();
            creditCart.UserId = vm.UserId;
            creditCart.IsActive = true;
            creditCart.CartName = vm.CartName;
            creditCart.CartNo = vm.CartNo;
            creditCart.Cvv = vm.Cvv;
            creditCart.ExpirationDate = vm.ExpirationDate;
            _creditCartBs.Insert(creditCart);
            return Json(new { Result = true, Message = "Kart Başarıyla Eklendi" });
        }
        [UserSessionAspect]
        [HttpPost]
        public IActionResult CreditCartDetails(int id)
        {
            CreditCart creditCart = _creditCartBs.CreditCartById(id);

            CreditCartDetailsVm vm = new CreditCartDetailsVm();
            vm.CartName = creditCart.CartName;
            vm.Id = creditCart.Id;
            vm.CartNo = creditCart.CartNo;
            vm.Cvv = creditCart.Cvv;
            vm.ExpirationDate = creditCart.ExpirationDate;
            return Json(new { CreditCartInfo = vm });
        }
        [UserSessionAspect]
        [HttpPost]
        public IActionResult CreditCartUpdate(CreditCartUpdateVm vm)
        {
            CreditCart creditCart = _creditCartBs.CreditCartById(vm.Id);

            creditCart.Id = vm.Id;
            creditCart.CartName = vm.CartName;
            creditCart.CartNo = vm.CartNo;
            creditCart.ExpirationDate = vm.ExpirationDate;
            creditCart.Cvv = vm.Cvv;
            _creditCartBs.Update(creditCart);

            return Json(new { Result = true, Message = "Kart Bilgileri Güncellendi" });
        }
        [UserSessionAspect]
        [HttpPost]
        public IActionResult DeleteCreditCart(int id)
        {
            _creditCartBs.Delete(id);

            return Json(new { Result = true, Message = "Kayıt Silindi" });
        }
        [UserSessionAspect]
        [HttpPost]
        public IActionResult UserProfileDelete(int id)
        {
            _userBs.Delete(id);

            return Json(new { Result = true, Message = "Hesap Kapatıldı" });
        }
    }
}
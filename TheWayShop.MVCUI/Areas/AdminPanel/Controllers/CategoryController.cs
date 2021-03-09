using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Core.Model.Enums;
using Core.Utilities.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TheWayShop.Business.Abstract;
using TheWayShop.Model.Entity;
using TheWayShop.Model.Enums;
using TheWayShop.Model.ViewModels.AdminPanel;
using TheWayShop.MVCUI.Aspects;

namespace TheWayShop.MVCUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [SessionAspect]
    [RoleAspect((int)AdminRoles.SuperAdmin, (int)AdminRoles.CategoryAdmin)]
    public class CategoryController : Controller
    {
        private readonly ICategoryBs _categoryBs;

        public CategoryController(ICategoryBs categoryBs)
        {
            _categoryBs = categoryBs;
        }

        public IActionResult List()
        {
            CategoryListVm vm = new CategoryListVm();
            //vm.CategoryList = _categoryBs
            //    .MainCategoryList(orderBy:x=>x.Priority.ToString())
            //    .Select(x => new SelectListItem() 
            //{
            //    Text = x.CategoryName,
            //    Value = x.Id.ToString()
            //}).ToList();
            //---------------------------------------
            vm.Categories = _categoryBs.CategoryList();
            vm.CategoryList = _categoryBs
                .MainCategoryListByDescending(orderBy: x => x.Priority.ToString())
                .Select(x => new SelectListItem()
                {
                    Text = x.CategoryName,
                    Value = x.Id.ToString()
                }).ToList();

            vm.CategoryList.Insert(0, new SelectListItem() { Text = "Seçiniz...", Value = "-1" });

            return View(vm);
        }
        [HttpPost]
        public IActionResult CategoryPhotoUpload()
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


                var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AdminPanel/img/CategoryPhotos", generatedFileName);

                using (var fileStream = new FileStream(uploadPath, FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }

                return Json(new { Result = true, PhotoPath = "/AdminPanel/img/CategoryPhotos/" + generatedFileName });
            }
            else
                return Json(new { Result = false, Message = "Lütfen dosya seçiniz" });

        }

        [HttpPost]
        public IActionResult New(NewCategoryVm vm)
        {
            if (!ModelState.IsValid)
            {
                string errorMessage = "";

                foreach (var item in ModelState.Values)
                {
                    foreach (var item1 in item.Errors)
                    {
                        errorMessage += item1.ErrorMessage + "<br />";
                    }
                    return Json(new { Result = false, Message = errorMessage });
                }
            }
            Category category = new Category();
            category.IsActive = vm.IsActive; // formdan seçilebilir olsun
            category.IsShownInMainPage = vm.IsShownInMainPage;
            category.TopCategoryId = vm.TopCategoryId == -1 ? null : vm.TopCategoryId as int?;
            category.CategoryName = vm.CategoryName;
            category.Priority = vm.Priority;
            category.CategoryPhoto = vm.CategoryPhoto;
            // diğer özellikleri size ait

            _categoryBs.Insert(category);

            return Json(new { Result = true, Message = "Kategori Başarıyla Kaydedildi" });

        }
        [HttpPost]
        public IActionResult DetailsCategory(int id)
        {
            Category category = _categoryBs.CategoryById(id);

            CategoryDetailsVm vm = new CategoryDetailsVm();
            vm.Id = category.Id;
            vm.CategoryName = category.CategoryName;
            vm.TopCategoryId = category.TopCategoryId;
            vm.IsShownInMainPage = category.IsShownInMainPage;
            vm.Priority = category.Priority;
            vm.IsActive = category.IsActive;
            vm.CategoryPhoto = category.CategoryPhoto;

            return Json(new { CategoryInfo = vm });

        }
        [HttpPost]
        public IActionResult CategoryPhotoUpdate()
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


                var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AdminPanel/img/CategoryPhotos", generatedFileName);

                using (var fileStream = new FileStream(uploadPath, FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }

                return Json(new { Result = true, PhotoPath = "/AdminPanel/img/CategoryPhotos/" + generatedFileName });
            }
            else
                return Json(new { Result = false, Message = "Lütfen dosya seçiniz" });

        }
        [HttpPost]
        public IActionResult CategoryUpdate(CategoryUpdateVm vm)
        {
            if (!ModelState.IsValid)
            {
                string errorMessage = "";

                foreach (var item in ModelState.Values)
                {
                    foreach (var item1 in item.Errors)
                    {
                        errorMessage += item1.ErrorMessage + "<br />";
                    }
                    return Json(new { Result = false, Message = errorMessage });
                }
            }
            Category category = _categoryBs.CategoryById(vm.Id);

            category.CategoryName = vm.CategoryName;
            category.IsShownInMainPage = vm.IsShownInMainPage;
            category.CategoryPhoto = vm.CategoryPhoto;
            category.TopCategoryId = vm.TopCategoryId;
            category.Priority = vm.Priority;
            category.IsActive = vm.IsActive;
            _categoryBs.Update(category);

            return Json(new { Result = true, Message = "Kategori Güncellendi." });
        }
        //[HttpPost]
        //public IActionResult CategoryDelete(int categoryId)
        //{
        //    _categoryBs.Delete(categoryId);

        //    return Json(new { Result = true, Message = "Kategori Başarıyla Silindi" });
        //}
        //[HttpPost]
        public IActionResult CategoryDelete(int categoryId)
        {
            _categoryBs.DeleteNoActive(categoryId);

            return Json(new { Result = true, Message = "Kategori Başarıyla Silindi" });
        }
    }
}
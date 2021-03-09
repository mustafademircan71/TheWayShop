using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWayShop.Business.Abstract;
using TheWayShop.Model.Entity;
using TheWayShop.Model.Enums;
using TheWayShop.Model.ViewModels.AdminPanel;
using TheWayShop.MVCUI.Aspects;

namespace TheWayShop.MVCUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [SessionAspect]
    [RoleAspect((int)AdminRoles.SuperAdmin, (int)AdminRoles.ProductAdmin)]
    public class BrandController : Controller
    {
        private readonly IBrandBs _brandBs;
        public BrandController(IBrandBs brandBs)
        {
            _brandBs = brandBs;
        }
        [HttpGet]
        public IActionResult List()
        {
            List<Brand> brand = _brandBs.BrandList();

            return View(brand);
        }
        [HttpPost]
        public IActionResult New(NewBrandVm vm)
        {
            Brand brand = new Brand();
            brand.BrandName = vm.BrandName;
            brand.IsActive = vm.IsActive;
            _brandBs.Insert(brand);

            return Json(new { Result = true, Message = "Marka Kaydedildi" });
        }
        [HttpPost]
        public IActionResult BrandDetails(int brandId)
        {
            Brand brand = _brandBs.BrandById(brandId);

            BrandDetailsVm vm = new BrandDetailsVm();
            vm.Id = brand.Id;
            vm.BrandName = brand.BrandName;
            vm.IsActive = brand.IsActive;

            return Json(new { BrandInfo = vm });
        }
        [HttpPost]
        public IActionResult BrandUpdate(BrandUpdateVm vm)
        {
            Brand brand = _brandBs.BrandById(vm.Id);

            brand.BrandName = vm.BrandName;
            brand.IsActive = vm.IsActive;
            _brandBs.Update(brand);

            return Json(new { Result = true, Message = "Marka başarıyla güncellendi" });
        }
        [HttpPost]
        public IActionResult BrandDelete(int brandId)
        {
            _brandBs.Delete(brandId);

            return Json(new { Result = true, Message = "Marka Slindi" });
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Common;
using Microsoft.AspNetCore.Http;
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
    [RoleAspect((int)AdminRoles.SuperAdmin, (int)AdminRoles.SubAdmin)]
    public class SliderController : Controller
    {
        private readonly ISliderBs _sliderBs;

        public SliderController(ISliderBs sliderBs)
        {
            _sliderBs = sliderBs;
        }
        [HttpGet]
        public IActionResult List()
        {
          List<Slider> slider = _sliderBs.ListSlider();

            return View(slider);
        }
        [HttpPost]
        public IActionResult SliderPhotoUpload()
        {
            IFormFileCollection files = Request.Form.Files;

            if (files.Count > 0)
            {
                if (!files[0].ContentType.StartsWith("image/"))
                    return Json(new { Result = false, Message = "Lütfen sadece resim dosya seçiniz" });

                //if (files[0].Length > (100 * 1024))
                //    return Json(new { Result = false, Message = "Lütfen 100 KB dan küçük dosya seçiniz" });

                var originalFileName = files[0].FileName;
                var generatedFileName = RandomValueGenerator.GenerateFileName(Path.GetExtension(originalFileName));


                var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AdminPanel/img/SliderImage", generatedFileName);

                using (var fileStream = new FileStream(uploadPath, FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }

                return Json(new { Result = true, PhotoPath = "/AdminPanel/img/SliderImage/" + generatedFileName });
            }
            else
                return Json(new { Result = false, Message = "Lütfen dosya seçiniz" });

        }
        [HttpPost]
        public IActionResult New(SliderNewVm vm)
        {
            if (!ModelState.IsValid)
            {
                string errorMessage = "";
                foreach (var vale in ModelState.Values)
                {
                    foreach (var error in vale.Errors)
                    {
                        errorMessage += error.ErrorMessage + "<br />";
                    }
                }
                return Json(new { Result = false, Message = errorMessage });
            }

            Slider slider = new Slider();

            slider.Id = vm.Id;
            slider.IsActive = vm.IsActive;
            slider.Header = vm.Header;
            slider.Description = vm.Description;
            slider.Link = vm.Link;
            slider.SliderImage = vm.SliderImage;

            _sliderBs.Insert(slider);

            return Json(new { Result = true, Message = "Slider Başarıyla Kaydedildi" });
        }
        [HttpPost]
        public IActionResult SliderDetails(int id)
        {

            Slider slider = _sliderBs.SliderById(id);

            SliderDetailsVm vm = new SliderDetailsVm();
            vm.Id = slider.Id;
            vm.Header = slider.Header;
            vm.Description = slider.Description;
            vm.Link = slider.Link;
            vm.IsActive = slider.IsActive;
            vm.SliderImage = slider.SliderImage;

            return Json(new { SliderInfo = vm });

        }
        [HttpPost]
        public IActionResult SliderPhotoUpdate()
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


                var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AdminPanel/img/SliderImage", generatedFileName);

                using (var fileStream = new FileStream(uploadPath, FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }

                return Json(new { Result = true, PhotoPath = "/AdminPanel/img/SliderImage/" + generatedFileName });
            }
            else
                return Json(new { Result = false, Message = "Lütfen dosya seçiniz" });
        }
        [HttpPost]
        public IActionResult SliderUpdate(SliderUpdateVm vm)
        {
            if (!ModelState.IsValid)
            {
                string errorMessage = "";
                foreach (var vale in ModelState.Values)
                {
                    foreach (var error in vale.Errors)
                    {
                        errorMessage += error.ErrorMessage + "<br />";
                    }
                }
                return Json(new { Result = false, Message = errorMessage });
            }
            Slider slider = _sliderBs.SliderById(vm.Id);

            slider.Header = vm.Header;
            slider.Description = vm.Description;
            slider.Link = vm.Link;
            slider.IsActive = vm.IsActive;
            slider.SliderImage = vm.SliderImage;
            _sliderBs.Update(slider);

            return Json(new { Result = true, Message = "Slider başarıyla güncellendi" });

        }
        //[HttpPost]
        //public IActionResult SliderDelete(int sliderId)
        //{
         
        //    _sliderBs.Delete(sliderId);

        //    return Json(new { Result = true, Message = "Slider Başarıyla Silindi" });
        //}
        [HttpPost]
        public IActionResult SliderDelete(int sliderId)
        {
            _sliderBs.DeleteNoActive(sliderId);
            return Json(new { Result = true, Message = "Slider Başarıyla Silindi" });
        }
    }
}

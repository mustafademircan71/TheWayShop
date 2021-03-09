using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
    //[RoleAspect((int)AdminRoles.SuperAdmin, (int)AdminRoles.ProductAdmin)]
    public class ProductController : Controller
    {
        private readonly IProductBs _productBs;
        private readonly IProductPhotoBs _productPhotoBs;
        private readonly ICategoryBs _categoryBs;
        private readonly IBrandBs _brandBs;

        public ProductController(IProductBs productBs, IProductPhotoBs productPhotoBs,ICategoryBs categoryBs, IBrandBs brandBs)
        {
            _productBs = productBs;
            _productPhotoBs = productPhotoBs;
            _categoryBs = categoryBs;
            _brandBs = brandBs;
        }

        public IActionResult List()
        {
            ProductListVm vm = new ProductListVm();
            vm.Products = _productBs.ProductList("Brand", "Category");
            vm.BrandList = _brandBs.BrandList().Select(x => new SelectListItem()
            {
                Text = x.BrandName,
                Value = x.Id.ToString()
            }).ToList();

            vm.BrandList.Insert(0, new SelectListItem() { Text = "Seçiniz...", Value = "-1" });

            vm.CategoryList = _categoryBs.SubCategoryList().Select(x => new SelectListItem()
            {
                Text = x.CategoryName,
                Value = x.Id.ToString()
            }).ToList();

            vm.CategoryList.Insert(0, new SelectListItem() { Text = "Seçiniz...", Value = "-1" });

            return View(vm);
        }

        [HttpPost]
        public IActionResult PhotoUpload(int id)
        {
            IFormFileCollection files = Request.Form.Files;

            if (files.Count > 0)
            {
                int counter = 0;

                foreach (var file in files)
                {
                    counter++;
                    var originalFileName = file.FileName;
                    var generatedFileName = RandomValueGenerator.GenerateFileName(Path.GetExtension(originalFileName));


                    var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AdminPanel/img/ProductPhotos", generatedFileName);

                    using (var fileStream = new FileStream(uploadPath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    ProductPhoto photo = new ProductPhoto();
                    photo.IsActive = true;
                    photo.IsCoverPhoto = counter == 1;
                    photo.Photo = "/AdminPanel/img/ProductPhotos/" + generatedFileName;
                    photo.ProductId = id;

                    _productPhotoBs.Insert(photo);
                }

                return Json(new { Result = true, Message = "Ürün ve Fotoğrafları Kaydedildi" });

            }
            else
                return Json(new { Result = false, Message = "Lütfen dosya seçiniz" });


        }


        [HttpPost]
        public IActionResult New(NewProductVm vm)
        {
            Product product = new Product();

            product.BrandId = vm.BrandId;
            product.CategoryId = vm.CategoryId;
            product.Description = vm.Description;
            product.DiscountRate = vm.Discount;
            product.IsActive = true;
            product.Price = vm.Price;
            product.ProductName = vm.ProductName;
            product.ShortDescription = vm.ShortDescription;
            product.Stock = vm.Stock;

            _productBs.Insert(product);

            return Json(new { Result = true, InsertedProductId = product.Id });

        }

        public IActionResult NewProductNewPage()
        {
            ProductListVm vm = new ProductListVm();
            vm.Products = _productBs.ProductList("Brand", "Category");
            vm.BrandList = _brandBs.BrandList().Select(x => new SelectListItem()
            {
                Text = x.BrandName,
                Value = x.Id.ToString()
            }).ToList();

            vm.BrandList.Insert(0, new SelectListItem() { Text = "Seçiniz...", Value = "-1" });

            vm.CategoryList = _categoryBs.SubCategoryList().Select(x => new SelectListItem()
            {
                Text = x.CategoryName,
                Value = x.Id.ToString()
            }).ToList();

            vm.CategoryList.Insert(0, new SelectListItem() { Text = "Seçiniz...", Value = "-1" });

            return View(vm);
        }


        [HttpPost]
        public IActionResult NewProductNewPage(NewProductNewPageVm vm)
        {
            if (!ModelState.IsValid)
            {
                string errorMessage = "";
                foreach (var value in ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        errorMessage += error.ErrorMessage + "<br />";
                    }
                }
                return Json(new { Result = false, Message = errorMessage });
            }
            Product product = new Product();
            product.BrandId = vm.BrandId;
            product.CategoryId = vm.CategoryId;
            product.ProductName = vm.ProductName;
            product.ShortDescription = vm.ShortDescription;
            product.IsActive = vm.IsActive;
            product.Price = vm.Price;
            product.Description = vm.Description;
            product.DiscountRate = vm.Discount;
            product.Stock = vm.Stock;
            _productBs.Insert(product);

            return Json(new { Result = true, InsertedProductId = product.Id });

        }
        
        public IActionResult ProductDeatilsAndUpdate(int productId)
        {
            Product product = _productBs.ProductById(productId);

            ProductDetailsVm vm = new ProductDetailsVm();
            vm.Id = product.Id;
            vm.ProductName = product.ProductName;
            vm.Description = product.Description;
            vm.Discount = product.DiscountRate;
            vm.Price = product.Price;
            vm.Stock = product.Stock;
            vm.ShortDescription = product.ShortDescription;
            vm.IsActive = product.IsActive;

            vm.Cateogries = _categoryBs.SubCategoryList().Select(x => new SelectListItem()
            {
                Text = x.CategoryName,
                Value = x.Id.ToString(),
                Selected = product.CategoryId == x.Id

            }).ToList();
            vm.Cateogries.Insert(0, new SelectListItem() { Text = "Seçiniz...", Value = "-1" });

            vm.Brands = _brandBs.BrandList().Select(x => new SelectListItem()
            {
                Text = x.BrandName,
                Value = x.Id.ToString(),
                Selected = product.BrandId == x.Id
            }).ToList();

            vm.Brands.Insert(0, new SelectListItem() { Text = "Seçiniz...", Value = "-1" });

            return View(vm);
        }

        [HttpPost]
        public IActionResult PhotoUpdate(int id)
        {
            IFormFileCollection files = Request.Form.Files;

            if (files.Count > 0)
            {
                int counter = 0;

                foreach (var file in files)
                {
                    counter++;
                    var originalFileName = file.FileName;
                    var generatedFileName = RandomValueGenerator.GenerateFileName(Path.GetExtension(originalFileName));


                    var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AdminPanel/img/ProductPhotos", generatedFileName);

                    using (var fileStream = new FileStream(uploadPath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    ProductPhoto photo = new ProductPhoto();
                    photo.IsActive = true;
                    photo.IsCoverPhoto = counter == 1;
                    photo.Photo = "/AdminPanel/img/ProductPhotos/" + generatedFileName;
                    photo.ProductId = id;

                    _productPhotoBs.Insert(photo);
                }

                return Json(new { Result = true, Message = "Ürün ve Fotoğrafları Kaydedildi" });

            }
            else
                return Json(new { Result = false, Message = "Lütfen dosya seçiniz" });


        }
        [HttpPost]
        public IActionResult ProductDeatilsAndUpdate(ProductUpdateVm vm)
        {
            if (!ModelState.IsValid)
            {
                string errorMessage = "";
                foreach (var value in ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        errorMessage += error.ErrorMessage + "<br />";
                    }
                }
                return Json(new { Result = false, Message = errorMessage });
            }
            Product product = _productBs.ProductById(vm.Id);

            product.ProductName = vm.ProductName;
            product.Price = vm.Price;
            product.ShortDescription = vm.ShortDescription;
            product.Description = vm.Description;
            product.DiscountRate = vm.Discount;
            product.IsActive = vm.IsActive;
            product.Stock = vm.Stock;
            product.CategoryId = vm.CategoryId;
            product.BrandId = vm.BrandId;
            _productBs.Update(product);

            return Json(new { Result = true, UpdatedProductId = product.Id });

        }
        //[HttpPost]
        //public IActionResult Delete(int productId)
        //{
        //     _productBs.Delete(productId);

        //    return Json(new { Result = true, Message = "Ürün Başarıyla Silindi" });
        //}
        [HttpPost]
        public IActionResult Delete(int productId)
        {
            _productBs.DeleteNoActive(productId);

            return Json(new { Result = true, Message = "Ürün Başarıyla Silindi" });
        }

    }
}
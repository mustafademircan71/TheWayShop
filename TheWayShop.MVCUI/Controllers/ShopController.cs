using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWayShop.Business.Abstract;
using TheWayShop.Model.Entity;
using TheWayShop.Model.ViewModels.Shop;

namespace TheWayShop.MVCUI.Controllers
{
    public class ShopController : Controller
    {
        private readonly ICategoryBs _categoryBs;
        private readonly IProductBs _productBs;
        private readonly IBrandBs _brandBs;
        private readonly IProductPhotoBs _productPhotoBs;
        private readonly IViewedProductBs _viewedProductBs;

        public ShopController(ICategoryBs categoryBs, IProductBs productBs, IBrandBs brandBs, IProductPhotoBs productPhotoBs, IViewedProductBs viewedProductBs)
        {
            _categoryBs = categoryBs;
            _productBs = productBs;
            _brandBs = brandBs;
            _productPhotoBs = productPhotoBs;
            _viewedProductBs = viewedProductBs;
        }

        [HttpGet]
        public IActionResult Index(int categoryId)
        {
            ShopIndexVm vm = new ShopIndexVm();

            vm.Brands = _brandBs.BrandList();
            vm.Categories = _categoryBs.MainCategoryList();

            foreach (var category in vm.Categories)
            {
                foreach (var subCategory in category.SubCategories)
                {
                    subCategory.Products = _productBs.ProductListByCategory(subCategory.Id);
                }
            }

            vm.ProductsOfCategory = _productBs.ProductListByCategory(categoryId);

            foreach (var product in vm.ProductsOfCategory)
            {
                product.ProductPhotos = _productPhotoBs.ProductPhotosByProductId(product.Id);
                
            }

            vm.ActiveCategoryId = categoryId;
            vm.ActiveCategoryTopCategoryId = _categoryBs.CategoryById(categoryId).TopCategoryId;
            
            return View(vm);
        }

        [HttpPost]
        public IActionResult SearchProduct(ShopIndexSearchParamaterVm parameters)
        {
            parameters.PriceRange = parameters.PriceRange.Replace(" ", "");
            string[] priceParts = parameters.PriceRange.Split('-');
            int minPrice = int.Parse(priceParts[0].Remove(0, 1));
            int maxPrice = int.Parse(priceParts[1].Remove(0, 1));

            List<Product> filteredProducts = _productBs.ProductListByCategoryAndPriceRange(parameters.CategoryId, minPrice, maxPrice);

            foreach (var product in filteredProducts)
            {
                product.ProductPhotos = _productPhotoBs.ProductPhotosByProductId(product.Id);

            }

            return PartialView("_ShopIndexProducts", filteredProducts);
        }

        [HttpPost]
        public IActionResult SearchProductByProductName(string productName)
        {
            // Aşağıdaki yapı _productBs.GetProductNamesByProductName(productName) şeklinde kullanılabilmelidir.

            List<string> filteredProductNames = null;

            if (!string.IsNullOrEmpty(productName))
            {
                filteredProductNames = _productBs.ProductList()
                                                .Where(x => x.ProductName.ToLower().StartsWith(productName.ToLower()))
                                                .Select(x => x.ProductName)
                                                .ToList();
            }
            
            return PartialView("_SearchByProductNameList", filteredProductNames);
        }

       [HttpGet]
        public IActionResult ProductDetails(int productId)
        {
            Product product = _productBs.ProductById(productId);
            product.ProductPhotos = _productPhotoBs.ProductPhotosByProductId(product.Id);

            ShopDetailsVm vm = new ShopDetailsVm();

            vm.Product = product;

            return View(vm);
        }
        [HttpPost]
        public IActionResult ViewedProductInsert(ViewedProudctVm vm)
        {
            ViewedProduct vP = new ViewedProduct();
            vP.IsActive = true;
            vP.UserId = vm.UserId;
            vP.ProductId = vm.ProductId;
            _viewedProductBs.Insert(vP);

            return Json(new { Result = true });
        }
    }
}
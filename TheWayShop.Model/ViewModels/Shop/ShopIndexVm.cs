using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Model.ViewModels.Shop
{
    public class ShopIndexVm
    {
        public List<Category> Categories { get; set; }
        public List<Product> ProductsOfCategory { get; set; }
        public List<Brand> Brands { get; set; }
        public List<string> SearchByProductNameList { get; set; }

        public int ActiveCategoryId { get; set; }
        public int? ActiveCategoryTopCategoryId { get; set; }
    }
}

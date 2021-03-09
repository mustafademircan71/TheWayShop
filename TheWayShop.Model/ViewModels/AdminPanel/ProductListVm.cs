using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Model.ViewModels.AdminPanel
{
    public class ProductListVm
    {
        public List<SelectListItem> BrandList { get; set; }
        public List<SelectListItem> CategoryList { get; set; }

        public List<Product> Products { get; set; }
    }
}

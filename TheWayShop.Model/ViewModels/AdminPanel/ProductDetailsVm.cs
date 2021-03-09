using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Model.ViewModels.AdminPanel
{
    public class ProductDetailsVm
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public int? Discount { get; set; }
        public int Stock { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public List<SelectListItem> Cateogries { get; set; }
        public List<SelectListItem> Brands { get; set; }

    }
}

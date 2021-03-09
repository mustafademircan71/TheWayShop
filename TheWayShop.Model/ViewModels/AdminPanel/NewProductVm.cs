using System;
using System.Collections.Generic;
using System.Text;

namespace TheWayShop.Model.ViewModels.AdminPanel
{
    public class NewProductVm
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public int Stock { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
    }
}

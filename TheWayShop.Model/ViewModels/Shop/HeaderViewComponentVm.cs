using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Model.ViewModels.Shop
{
    public class HeaderViewComponentVm
    {
        public List<Category> Categories { get; set; }
        public List<Cart> UserCart { get; set; }
    }
}

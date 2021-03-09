using System;
using System.Collections.Generic;
using System.Text;

namespace TheWayShop.Model.ViewModels.Shop
{
    public class AddToCartVm
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}

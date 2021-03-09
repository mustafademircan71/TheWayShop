using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Model.ViewModels.Shop
{
    public class CreditCartVm
    {
        public User User { get; set; }
        public CreditCart CreditCart { get; set; }

        public List<CreditCart> CreditCarts { get; set; }
    }
}

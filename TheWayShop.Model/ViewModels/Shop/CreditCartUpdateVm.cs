using System;
using System.Collections.Generic;
using System.Text;

namespace TheWayShop.Model.ViewModels.Shop
{
    public class CreditCartUpdateVm
    {
        public int Id { get; set; }
        public string CartName { get; set; }
        public string CartNo { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Cvv { get; set; }
    }
}

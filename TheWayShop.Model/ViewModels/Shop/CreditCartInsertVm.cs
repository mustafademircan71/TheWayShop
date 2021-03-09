using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Model.ViewModels.Shop
{
    public class CreditCartInsertVm
    {
    
        public string CartName { get; set; }
        public string CartNo { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Cvv { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

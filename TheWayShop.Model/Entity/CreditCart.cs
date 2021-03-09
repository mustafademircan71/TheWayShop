using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheWayShop.Model.Entity
{
    public class CreditCart:BaseEntity
    {
        public string CartName { get; set; }
        public string CartNo { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Cvv { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}

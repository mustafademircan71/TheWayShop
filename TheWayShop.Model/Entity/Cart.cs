using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheWayShop.Model.Entity
{
    public class Cart:BaseEntity
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}

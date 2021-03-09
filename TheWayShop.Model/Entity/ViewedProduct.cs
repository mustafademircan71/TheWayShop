using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheWayShop.Model.Entity
{
    public class ViewedProduct:BaseEntity
    {
        public int? UserId { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}

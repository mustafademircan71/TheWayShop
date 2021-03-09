using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheWayShop.Model.Entity
{
    public class ProductPhoto:BaseEntity
    {
        public int? ProductId { get; set; }
        public string Photo { get; set; }
        public bool IsCoverPhoto { get; set; }

        public virtual Product Product { get; set; }
    }
}

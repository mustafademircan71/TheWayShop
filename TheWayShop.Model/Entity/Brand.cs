using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheWayShop.Model.Entity
{
    public class Brand : BaseEntity
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        public string BrandName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

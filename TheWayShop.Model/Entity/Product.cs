using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheWayShop.Model.Entity
{
    public class Product:BaseEntity
    {
        public Product()
        {
            ProductPhotos = new HashSet<ProductPhoto>();
            CartItems = new HashSet<Cart>();
        }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public int? DiscountRate { get; set; }
        public int Stock { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ProductPhoto> ProductPhotos { get; set; }
        public virtual ICollection<Cart> CartItems { get; set; }
    }
}

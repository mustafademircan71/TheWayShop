using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheWayShop.Model.Entity
{
    public class Category : BaseEntity
    {
        public Category()
        {
            SubCategories = new HashSet<Category>();
            Products = new HashSet<Product>();
        }

        public string CategoryName { get; set; }
        public string CategoryPhoto { get; set; }
        public bool? IsShownInMainPage { get; set; }
        public int? TopCategoryId { get; set; }
        public int Priority { get; set; }

        public virtual Category TopCategory { get; set; }
        public virtual ICollection<Category> SubCategories { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}

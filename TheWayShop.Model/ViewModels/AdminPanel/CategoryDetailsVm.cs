using System;
using System.Collections.Generic;
using System.Text;

namespace TheWayShop.Model.ViewModels.AdminPanel
{
    public class CategoryDetailsVm
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int? TopCategoryId { get; set; }
        public bool? IsShownInMainPage { get; set; }
        public int Priority { get; set; }
        public bool IsActive { get; set; }
        public string CategoryPhoto { get; set; }


    }
}

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Model.ViewModels.AdminPanel
{
    public class CategoryListVm
    {
        public List<Category> Categories { get; set; }
        public List<SelectListItem> CategoryList { get; set; }
    }
}

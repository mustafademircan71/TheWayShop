using System;
using System.Collections.Generic;
using System.Text;

namespace TheWayShop.Model.ViewModels.AdminPanel
{
    public class BrandUpdateVm
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public bool IsActive { get; set; }
    }
}

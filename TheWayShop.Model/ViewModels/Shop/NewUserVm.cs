using System;
using System.Collections.Generic;
using System.Text;

namespace TheWayShop.Model.ViewModels.Shop
{
    public class NewUserVm
    {
        public bool IsActive { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Model.ViewModels.AdminPanel
{
    public class AdminListVm
    {
        public List<Admin> Admins { get; set; }
        public List<SelectListItem> Roles { get; set; }
    }
}

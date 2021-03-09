using System;
using System.Collections.Generic;
using System.Text;

namespace TheWayShop.Model.ViewModels.AdminPanel
{
    public class AdminDetailsVm
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public bool IsActive { get; set; }
        public int? RoleId { get; set; }
    }
}

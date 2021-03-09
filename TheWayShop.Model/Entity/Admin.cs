using Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheWayShop.Model.Entity
{
    public class Admin:BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public int? RoleId { get; set; }

        public virtual Role Role { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheWayShop.Model.ViewModels.AdminPanel
{
    public class AdminUpdateVm
    {
        public int Id { get; set; }
        //---------------------------------
        [Required(ErrorMessage = "Ad Soyad Boş Bırakılamaz")]
        [MinLength(2, ErrorMessage = "Ad Soyad En Az 2 karakterden oluşmalıdır")]
        public string FullName { get; set; }
        //-------------------------------------
        [Required(ErrorMessage = "Email Zorunludur")]
        [EmailAddress(ErrorMessage = "Geçerli bir email girilmelidir")]
        public string Email { get; set; }
        //---------------------------------------
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        public bool? IsActive { get; set; }
        public string Photo { get; set; }
        public int? RoleId { get; set; }
    }
}

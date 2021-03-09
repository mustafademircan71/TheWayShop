using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheWayShop.Model.ViewModels.AdminPanel
{
    public class NewCategoryVm
    {
        [Required(ErrorMessage = "Ad Soyad Boş Bırakılamaz")]
        [MinLength(2, ErrorMessage = "Ad Soyad En Az 2 karakterden oluşmalıdır")]
        public string CategoryName { get; set; }
 
        public int TopCategoryId { get; set; }
        public bool IsShownInMainPage { get; set; }
        public int Priority { get; set; }
        public string CategoryPhoto { get; set; }
        public bool IsActive { get; set; }
    }
}

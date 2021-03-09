using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheWayShop.Model.ViewModels.AdminPanel
{
    public class CategoryUpdateVm
    {
        public int Id { get; set; }
        //----------------------------------------
        [Required(ErrorMessage ="Kategori Adı Boş Bırakılamaz")]
        [MinLength(2,ErrorMessage ="En Az İki Karakterden Oluşmalıdır.")]
        public string CategoryName { get; set; }
        
        public int? TopCategoryId { get; set; }
        public bool? IsShownInMainPage { get; set; }
        public int Priority { get; set; }
        public bool IsActive { get; set; }
        public string CategoryPhoto { get; set; }
    }
}

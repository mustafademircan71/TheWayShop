using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheWayShop.Model.ViewModels.AdminPanel
{
    public class SliderNewVm
    {
        public int Id { get; set; }
         public string SliderImage { get; set; }
        //--------------------------------------
        [Required(ErrorMessage ="Başlık Boş Bırakılmaz")]
        [MinLength(2,ErrorMessage ="En Az İki Karakterden Oluşmaldır.")]
        public string Header { get; set; }
        //------------------------------------------
        [Required(ErrorMessage ="Açıklama Boş Bırakılamaz")]
        [MinLength(15,ErrorMessage ="Açıklama En Az 15 Karakterden Oluşmalıdır.")]
        public string Description { get; set; }
        //---------------------------------------------------
        [Required(ErrorMessage ="Link Boş Bırakılamaz")]
        public string Link { get; set; }
        //-------------------------------------------
        public bool IsActive { get; set; }
    }
}

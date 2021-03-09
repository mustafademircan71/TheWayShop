using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheWayShop.Model.ViewModels.Shop
{
    public class NewMessageVm
    {
        public int Id { get; set; }
        //-----------------------------
        [Required(ErrorMessage ="Ad Soyadı Boş Bırakalamaz" )]
        [MinLength(2,ErrorMessage ="En Az İki Karakter Olmalıdır")]
        public string FullName { get; set; }
        //-------------------------------------------
        [Required(ErrorMessage ="Mail Adresi Boş Bırakılamaz")]
        [EmailAddress(ErrorMessage ="Geçerli Bir Email Adresi Olamalıdr.")]
        public string Mail { get; set; }
        //-----------------------------------------
        [Required(ErrorMessage = "Konu Boş Bırakalamaz")]
        [MinLength(2, ErrorMessage = "En Az İki Karakter Olmalıdır")]
        public string Subject { get; set; }
        //-------------------------------------------
        [Required(ErrorMessage = "Bu Alan Boş Bırakalamaz")]
        [MinLength(10, ErrorMessage = "En Az On Karakter Olmalıdır")]
        public string Messages { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace TheWayShop.Model.ViewModels.Shop
{
    public class UserUpdateVm
    {
        public int Id { get; set; }
        //----------------------------------------------
        [Required(ErrorMessage = "Ad Soyad Boş Bırakılamaz")]
        [MinLength(2, ErrorMessage = "Ad Soyad En Az 2 karakterden oluşmalıdır")]
        public string FullName { get; set; }
        //--------------------------------------
        [Required(ErrorMessage = "E-Mail Boş Bırakılamaz")]
        [EmailAddress(ErrorMessage = "E-mail Formatında Olmalıdır")]
        public string Email { get; set; }
        //--------------------------------------------
        [Required(ErrorMessage = "Şehir Boş Bırakılamaz")]
        [MinLength(2,ErrorMessage = "En Az İki Karakterden Oluşmalıdr")]
        public string City { get; set; }
        //--------------------------------------------
        [Required(ErrorMessage = "Ülke Boş Bırakılamaz")]
        [MinLength(2, ErrorMessage = "En Az İki Karakterden Oluşmalıdr")]
        public string Country { get; set; }
        //--------------------------------------------
        [Required(ErrorMessage = "Adres Boş Bırakılamaz")]
        [MinLength(15, ErrorMessage = "En Az Onbeş Karakterden Oluşmalıdr")]
        public string Adress { get; set; }
        //--------------------------------------------
        [Required(ErrorMessage = "Telefon Boş Bırakılamaz")]
        [MinLength(11, ErrorMessage = "En Az Onbir Karakterden Oluşmalıdr")]
        [MaxLength(11,ErrorMessage ="En Fazla Onbir Haneden Oluşmalıdır.")]
        public string Phone { get; set; }

    }
}

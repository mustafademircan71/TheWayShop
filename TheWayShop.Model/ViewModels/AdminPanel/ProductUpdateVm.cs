using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheWayShop.Model.ViewModels.AdminPanel
{
    public class ProductUpdateVm
    {
        public int Id { get; set; }
        //----------------------------------
        [Required(ErrorMessage = "Ürün İsmi Boş Bırakılamaz ")]
        [MinLength(2, ErrorMessage = "Ürün İsmi En Az İki Karakterden Oluşmalıdır.")]
        public string ProductName { get; set; }
        //----------------------------------
        [Required(ErrorMessage = "Fiyat Boş Bırakılamaz")]
        public decimal Price { get; set; }
        //----------------------------------
        public int Discount { get; set; }
        //---------------------------------------
        [Required(ErrorMessage = "Stok Miktarı Boş Bırakılamaz")]
        public int Stock { get; set; }
        //---------------------------------
        [Required(ErrorMessage = "Açıklama Boş Bırakılamaz")]
        [MinLength(15, ErrorMessage = "Kısa Açıklama En Az 15 Karekter Olmalıdır.")]
        public string ShortDescription { get; set; }
        //----------------------------------------
        [Required(ErrorMessage = "Açıklama Boş Bırakılamaz")]
        [MinLength(15, ErrorMessage = "Kısa Açıklama En Az 15 Karekter Olmalıdır.")]
        public string Description { get; set; }
        //------------------------------------
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public bool IsActive { get; set; }
    }
}


using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheWayShop.Model.Entity
{
    public class User : BaseEntity
    {
        public User()
        {
            CartItems = new HashSet<Cart>();
            CreditCarts = new HashSet<CreditCart>();
        }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
      
        public virtual ICollection<CreditCart> CreditCarts { get; set; }
        public virtual ICollection<Cart> CartItems { get; set; }
    }
}

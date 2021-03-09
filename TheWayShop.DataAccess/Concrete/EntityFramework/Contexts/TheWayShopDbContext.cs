using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.DataAccess.Concrete.EntityFramework.Contexts
{
    public class TheWayShopDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-5AIG14N\\MUSTAFA;database=TheWayShopDb;trusted_connection=true;");
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<ViewedProduct> ViewedProducts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<SendMessage> SendMessages { get; set; }
        public DbSet<CreditCart> CreditCarts { get; set; }
    }
}

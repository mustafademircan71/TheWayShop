using Core.DataAccess;
using Core.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.DataAccess.Abstract;
using TheWayShop.DataAccess.Concrete.EntityFramework.Contexts;
using TheWayShop.Model.Entity;

namespace TheWayShop.DataAccess.Concrete.EntityFramework.Repositories
{
    public class AdminRepositoryEntityFramework : RepositoryEntityFramework<Admin, TheWayShopDbContext>, IAdminRepository
    {
        public Admin LogIn(string email, string password, params string[] includeList)
        {
            return Get(x => x.Email == email && x.Password == password,includeList);
        }
    }
}

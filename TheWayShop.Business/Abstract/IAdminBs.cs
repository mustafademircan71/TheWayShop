using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Abstract
{
    public interface IAdminBs
    {
        List<Admin> AdminList(params string[] includeList);
        Admin AdminById(int id, params string[] includeList);
        Admin AdminByEmail(string email, params string[] includeList);
        Admin LogIn(string email, string password, params string[] includeList);
        void Update(Admin admin);
        void Insert(Admin admin);
        void Delete(int id);
        void DeleteNoActive(int id);

    }
}

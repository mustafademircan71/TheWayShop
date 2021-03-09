using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Abstract
{
    public interface IUserBs
    {
        List<User> UserList(params string[] includeList);
        User UserById(int id, params string[] includeList);
        User UserByEmail(string email, params string[] includeList);
        User LogIn(string email, string password, params string[] includeList);

        void Update(User user);
        void Insert(User user);

        void Delete(int id);
    }
}

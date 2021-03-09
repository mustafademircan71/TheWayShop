using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Business.Abstract;
using TheWayShop.DataAccess.Abstract;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Concrete
{
    public class UserBs : IUserBs
    {
        private readonly IUserRepository _repo;

        public UserBs(IUserRepository repo)
        {
            _repo = repo;
        }
        public User UserByEmail(string email, params string[] includeList)
        {
            return _repo.Get(x => x.Email == email, includeList);
        }

        public User UserById(int id, params string[] includeList)
        {
            return _repo.GetById(id, includeList);
        }

        public List<User> UserList(params string[] includeList)
        {
            // iş
            return _repo.GetAll(filter: null, includeList: includeList);
            // iş
        }

        public void Delete(int id)
        {
            _repo.DeleteNoActive(id);
        }

        public void Insert(User user)
        {
            _repo.Insert(user);
        }

       

        public void Update(User user)
        {
            _repo.Update(user);
        }

        public User LogIn(string email, string password, params string[] includeList)
        {
           return _repo.LogIn(email, password, includeList);
        }
    }
}

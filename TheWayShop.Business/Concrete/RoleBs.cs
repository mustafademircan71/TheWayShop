using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Business.Abstract;
using TheWayShop.DataAccess.Abstract;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Concrete
{
    public class RoleBs : IRoleBs
    {
        private readonly IRoleRepository _repo;

        public RoleBs(IRoleRepository repo)
        {
            _repo = repo;
        }

        public List<Role> RoleList()
        {
            return _repo.GetAll();
        }
    }
}

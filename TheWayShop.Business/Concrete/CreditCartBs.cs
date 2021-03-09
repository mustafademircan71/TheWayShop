using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Business.Abstract;
using TheWayShop.DataAccess.Abstract;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Concrete
{
    public class CreditCartBs : ICreditCartBs
    {
        private readonly ICreditCartRepository _repo;
        public CreditCartBs(ICreditCartRepository repo)
        {
            _repo = repo;
        }
        public CreditCart CreditCartById(int id, params string[] includeList)
        {
            return _repo.GetById(id);
        }

        public CreditCart CreditCartByUser(int userId, params string[] includeList)
        {
           return _repo.Get(x => x.UserId == userId, includeList);
        }

        public List<CreditCart> CreditCartByUserList(int userId, params string[] includeList)
        {
            return _repo.GetAll(filter: x => x.UserId == userId, includeList: includeList);
        }

        public List<CreditCart> CreditCarts(params string[] includeList)
        {
            return _repo.GetAll();
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public void Insert(CreditCart creditCart)
        {
            _repo.Insert(creditCart);
        }

        public void Update(CreditCart creditCart)
        {
            _repo.Update(creditCart);
        }
    }
}

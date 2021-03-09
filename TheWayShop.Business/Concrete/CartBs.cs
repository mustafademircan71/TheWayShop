using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Business.Abstract;
using TheWayShop.DataAccess.Abstract;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Concrete
{
    public class CartBs : ICartBs
    {
        private readonly ICartRepository _repo;

        public CartBs(ICartRepository repo)
        {
            _repo = repo;
        }

        public List<Cart> CartListByUserId(int userId,params string[] includeList)
        {
            return _repo.GetAll(
                filter: x=>x.UserId == userId,
                includeList: includeList);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public Cart GetById(int id, params string[] includeList)
        {
            return _repo.GetById(id, includeList);
        }

        public Cart GetByUserIdAndProductId(int userId, int productId, params string[] includeList)
        {
            return _repo.Get(filter: x => x.UserId == userId && x.ProductId == productId, includeList: includeList);
        }

        public void Insert(Cart cart)
        {
            _repo.Insert(cart);
        }

        public void Update(Cart cart)
        {
            _repo.Update(cart);
        }
    }
}

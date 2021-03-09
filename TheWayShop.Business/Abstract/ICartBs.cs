using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Abstract
{
    public interface ICartBs
    {
        List<Cart> CartListByUserId(int userId,params string[] includeList);
        Cart GetByUserIdAndProductId(int userId, int productId, params string[] includeList);
        Cart GetById(int id, params string[] includeList);

        void Update(Cart cart);
        void Insert(Cart cart);

        void Delete(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Abstract
{
    public interface ICreditCartBs
    {
        List<CreditCart> CreditCarts(params string[] includeList);
        List<CreditCart> CreditCartByUserList(int userId,params string[] includeList);
        CreditCart CreditCartById(int id, params string[] includeList);
        CreditCart CreditCartByUser(int userId, params string[] includeList);
        void Insert(CreditCart creditCart);
        void Update(CreditCart creditCart);
        void Delete(int id);

    }
}

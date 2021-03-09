using Core.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.DataAccess.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}

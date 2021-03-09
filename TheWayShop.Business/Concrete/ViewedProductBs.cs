using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Business.Abstract;
using TheWayShop.DataAccess.Abstract;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Concrete
{
    public class ViewedProductBs : IViewedProductBs
    {
        private readonly IViewedProductRepository _repo;
        public ViewedProductBs(IViewedProductRepository repo)
        {
            _repo = repo;
        }
        public void Insert(ViewedProduct viewedProduct)
        {
            _repo.Insert(viewedProduct);
        }

        public List<ViewedProduct> ViewedProductList(params string[] includeList)
        {
            return _repo.GetAll();
        }
    }
}

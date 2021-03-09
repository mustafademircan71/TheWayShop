using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Business.Abstract;
using TheWayShop.DataAccess.Abstract;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Concrete
{
    public class ProductPhotoBs : IProductPhotoBs
    {
        private readonly IProductPhotoRepository _repo;

        public ProductPhotoBs(IProductPhotoRepository repo)
        {
            _repo = repo;
        }

        public ProductPhoto ProductPhotoById(int id, params string[] includeList)
        {
            return _repo.GetById(id, includeList);
        }

        public List<ProductPhoto> ProductPhotoList(params string[] includeList)
        {
            return _repo.GetAll(
                filter: null,
                includeList: includeList);
        }

        public void Insert(ProductPhoto productPhoto)
        {
            _repo.Insert(productPhoto);
        }

        public void Update(ProductPhoto productPhoto)
        {
            _repo.Update(productPhoto);
        }

        public List<ProductPhoto> ProductPhotosByProductId(int productId, params string[] includeList)
        {
            return _repo.GetAll(filter:x => x.ProductId == productId, includeList: includeList);
        }
    }
}

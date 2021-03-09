using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Business.Abstract;
using TheWayShop.DataAccess.Abstract;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Concrete
{
    public class ProductBs : IProductBs
    {
        private readonly IProductRepository _repo;

        public ProductBs(IProductRepository repo)
        {
            _repo = repo;
        }

        public Product ProductById(int id, params string[] includeList)
        {
            return _repo.GetById(id, includeList);
        }

        public List<Product> ProductList(params string[] includeList)
        {
            return _repo.GetAll(
                filter: null,
                includeList: includeList);
        }

        public void Insert(Product product)
        {
            _repo.Insert(product);
        }

        public void Update(Product product)
        {
            _repo.Update(product);
        }

        public List<Product> ProductListByCategory(int categoryId, params string[] includeList)
        {
            return _repo.GetAll(
                filter:x => x.CategoryId == categoryId, 
                includeList:includeList);
        }

        public void Delete(int productıd)
        {
            _repo.Delete(productıd);
        }

        public List<Product> ProductListByCategoryAndPriceRange(int categoryId, int minPrice, int maxPrice, params string[] includeList)
        {
            return _repo.GetAll(filter: x => x.CategoryId == categoryId && x.Price >= minPrice && x.Price <= maxPrice, includeList: includeList);
        }
        public List<Product> GetProductPhotos(int productId)
        {
            return _repo.GetAll(filter: x => x.Id == productId);
        }

        public void DeleteNoActive(int id)
        {
            _repo.DeleteNoActive(id);
        }
    }
}

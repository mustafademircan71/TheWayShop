using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Abstract
{
    public interface IProductBs
    {
        List<Product> ProductList(params string[] includeList);
        List<Product> ProductListByCategory(int categoryId,params string[] includeList);
        List<Product> ProductListByCategoryAndPriceRange(int categoryId,int minPrice,int maxPrice, params string[] includeList);
        Product ProductById(int id, params string[] includeList);

        void Update(Product product);
        void Insert(Product product);
        void Delete(int productıd);
        List<Product> GetProductPhotos(int productId);
        void DeleteNoActive(int id);

    }
}

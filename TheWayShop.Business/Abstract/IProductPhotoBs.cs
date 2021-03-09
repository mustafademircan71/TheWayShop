using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Abstract
{
    public interface IProductPhotoBs
    {
        List<ProductPhoto> ProductPhotoList(params string[] includeList);
        List<ProductPhoto> ProductPhotosByProductId(int productId,params string[] includeList);
        ProductPhoto ProductPhotoById(int id, params string[] includeList);

        void Update(ProductPhoto productPhoto);
        void Insert(ProductPhoto productPhoto);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Abstract
{
    public interface IBrandBs
    {
        List<Brand> BrandList(params string[] includeList);
        Brand BrandById(int id, params string[] includeList);

        void Update(Brand brand);
        void Insert(Brand brand);

        void Delete(int brandId);
    }
}

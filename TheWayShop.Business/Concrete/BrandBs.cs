using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Business.Abstract;
using TheWayShop.DataAccess.Abstract;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Concrete
{
    public class BrandBs : IBrandBs
    {
        private readonly IBrandRepository _repo;

        public BrandBs(IBrandRepository repo)
        {
            _repo = repo;
        }

        public Brand BrandById(int id, params string[] includeList)
        {
            return _repo.GetById(id, includeList);
        }

        public List<Brand> BrandList(params string[] includeList)
        {
            return _repo.GetAll(
                filter: null,
                includeList: includeList);
        }

        public void Delete(int brandId)
        {
            _repo.Delete(brandId);
        }

        public void Insert(Brand brand)
        {
            _repo.Insert(brand);
        }

        public void Update(Brand brand)
        {
            _repo.Update(brand);
        }
    }
}

using Core.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Business.Abstract;
using TheWayShop.DataAccess.Abstract;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Concrete
{
    public class CategoryBs : ICategoryBs
    {
        private readonly ICategoryRepository _repo;

        public CategoryBs(ICategoryRepository repo)
        {
            _repo = repo;
        }

        public Category CategoryById(int id, params string[] includeList)
        {
            return _repo.GetById(id, includeList);
        }

        public List<Category> CategoryList(params string[] includeList)
        {
            return _repo.GetAll(
                filter:null, 
                includeList:includeList);
        }

        public void Delete(int categoryId)
        {
            _repo.Delete(categoryId);
        }

        public void DeleteNoActive(int id)
        {
            _repo.DeleteNoActive(id);
        }

        public void Insert(Category category)
        {
            _repo.Insert(category);
        }

        
        public List<Category> MainCategoryList(Func<Category,string> orderBy=null, params string[] includeList)
        {
            return _repo.GetAll(
                filter:x => x.TopCategoryId == null,
                orderBy:orderBy,
                direction:Direction.Ascending,
                includeList:includeList);
        }

        
        public List<Category> MainCategoryListByDescending(Func<Category, string> orderBy = null, params string[] includeList)
        {
            return _repo.GetAll(
                filter: x => x.TopCategoryId == null,
                orderBy: orderBy,
                direction: Direction.Descending,
                includeList: includeList);
        }

        public List<Category> SubCategoryList(Func<Category, bool> filter, Func<Category, string> orderBy = null, int?  top = null, params string[] includeList)
        {
            return _repo.GetAll(
                filter: x => x.TopCategoryId != null,
                orderBy:orderBy,
                top: top);
            
        }

        public void Update(Category category)
        {
            _repo.Update(category);
        }
    }
}

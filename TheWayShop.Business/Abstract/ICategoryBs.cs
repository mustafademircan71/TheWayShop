using Core.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Abstract
{
    public interface ICategoryBs
    {
        List<Category> CategoryList(params string[] includeList);
        /// <summary>
        /// Sadece ana kategorileri döndürür ve bu kategorilerin belirtilen kolona göre artan sıralamasını yapar, eğer sıralama kolonu belirtilmezse varsayılan olarak Id alanına göre sıralama yapar
        /// </summary>
        /// <param name="orderBy"></param>
        /// <param name="includeList"></param>
        /// <returns></returns>
        List<Category> MainCategoryList(Func<Category,string> orderBy=null,params string[] includeList);
        /// <summary>
        /// Sadece ana kategorileri döndürür ve bu kategorilerin belirtilen kolona göre azalan sıralamasını yapar, eğer sıralama kolonu belirtilmezse varsayılan olarak Id alanına göre sıralama yapar
        /// </summary>
        /// <param name="orderBy"></param>
        /// <param name="includeList"></param>
        /// <returns></returns>
        List<Category> MainCategoryListByDescending(Func<Category, string> orderBy = null, params string[] includeList);
        Category CategoryById(int id, params string[] includeList);

        List<Category> SubCategoryList(Func<Category,bool> filter=null, Func<Category,string> orderBy=null, int?  top = null, params string[] includeList);

        void Update(Category category);
        void Insert(Category category);
        void Delete(int categoryId);
        void DeleteNoActive(int id);
    }
}

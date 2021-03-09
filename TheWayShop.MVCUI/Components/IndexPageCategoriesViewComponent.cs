using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheWayShop.Business.Abstract;
using TheWayShop.Model.Entity;

namespace TheWayShop.MVCUI.Components
{
    public class IndexPageCategoriesViewComponent:ViewComponent
    {
        private readonly ICategoryBs _categoryBs;

        public IndexPageCategoriesViewComponent(ICategoryBs categoryBs)
        {
            _categoryBs = categoryBs;
        }

        public IViewComponentResult Invoke(int categoryCount)
        {
            List<Category> subCategories = _categoryBs.SubCategoryList(filter:x=>x.IsShownInMainPage.Value,orderBy:x=>x.Priority.ToString(),top: categoryCount); 
            
            
            // BU METODA HEM FİLTERELEME HEM DE SIRALAMA YAPILABİLSİN (filtre IsShownInMainPage için kullanılacak, sıralama Priority için kullanılacak)
            return View(subCategories);
        }
        
    }
}

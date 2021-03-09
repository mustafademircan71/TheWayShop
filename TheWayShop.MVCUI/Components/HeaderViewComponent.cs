using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheWayShop.Business.Abstract;
using TheWayShop.Model.Entity;
using TheWayShop.Model.ViewModels.Shop;
using TheWayShop.MVCUI.Extensions;

namespace TheWayShop.MVCUI.Components
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly ICategoryBs _categoryBs;
        private readonly ICartBs _cartBs;

        public HeaderViewComponent(ICategoryBs categoryBs, ICartBs cartBs)
        {
            _categoryBs = categoryBs;
            _cartBs = cartBs;
        }

        public IViewComponentResult Invoke()
        {
            User activeUser = HttpContext.Session.GetObject<User>("ActiveUser");

            HeaderViewComponentVm vm = new HeaderViewComponentVm();

            vm.Categories = _categoryBs.CategoryList();
            vm.UserCart = activeUser != null ? _cartBs.CartListByUserId(activeUser.Id,"Product") : null;
            

            return View(vm);
        }
    }
}

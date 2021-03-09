using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using TheWayShop.Model.Entity;
using TheWayShop.MVCUI.Extensions;

namespace TheWayShop.MVCUI.Areas.AdminPanel.Components
{
    public class PanelLeftMenuViewComponent:ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            Admin activeAdmin = HttpContext.Session.GetObject<Admin>("ActiveAdmin");

            return View(activeAdmin);
        }
    }
}

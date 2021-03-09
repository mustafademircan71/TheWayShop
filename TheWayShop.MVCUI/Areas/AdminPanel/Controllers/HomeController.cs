using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheWayShop.Model.Entity;
using TheWayShop.MVCUI.Models;
using TheWayShop.MVCUI.Extensions;
using TheWayShop.MVCUI.Aspects;

namespace TheWayShop.MVCUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [SessionAspect]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}

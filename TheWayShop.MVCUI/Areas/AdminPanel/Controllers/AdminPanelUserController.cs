using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWayShop.Model.Enums;
using TheWayShop.MVCUI.Aspects;

namespace TheWayShop.MVCUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [SessionAspect]
    [RoleAspect((int)AdminRoles.SuperAdmin)]
    public class AdminPanelUserController : Controller
    {
        public IActionResult UserList()
        {
            return View();
        }
    }
}

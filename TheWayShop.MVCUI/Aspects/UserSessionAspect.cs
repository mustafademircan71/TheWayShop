using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheWayShop.Model.Entity;
using TheWayShop.MVCUI.Extensions;

namespace TheWayShop.MVCUI.Aspects
{
    public class UserSessionAspect : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            User activeUser = context.HttpContext.Session.GetObject<User>("ActiveUser");

            if (activeUser == null)
                context.Result = new RedirectToActionResult("LogIn", "User", null);
        }
    }
}

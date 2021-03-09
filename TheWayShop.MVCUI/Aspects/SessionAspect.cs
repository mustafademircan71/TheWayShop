using Microsoft.AspNetCore.Http;
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
    public class SessionAspect:ActionFilterAttribute,IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Admin activeAdmin = context.HttpContext.Session.GetObject<Admin>("ActiveAdmin");

            if (activeAdmin == null)
                context.Result = new RedirectToActionResult("LogIn", "Admin", null);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.Linq;
using TheWayShop.Model.Entity;
using TheWayShop.MVCUI.Extensions;

namespace TheWayShop.MVCUI.Aspects
{
    public class RoleAspect : ActionFilterAttribute, IActionFilter
    {
        private List<int> AllowedRoles { get; set; }

        public RoleAspect(params int[] allowedRoles) 
        {
            AllowedRoles = allowedRoles.OfType<int>().ToList();
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Admin activeAdmin = context.HttpContext.Session.GetObject<Admin>("ActiveAdmin");

            if (!AllowedRoles.Contains(activeAdmin.RoleId.Value))
            {
                bool isAjax = context.HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest";

                if (isAjax)
                {
                    context.Result = new JsonResult(new {Result=false,Message="Bu işlemi yapmaya yetkiniz yok" });
                }
                else
                {
                    context.Result = new RedirectToActionResult("Index", "Home", null);
                }
                
            }
                

            
        }
    }
}

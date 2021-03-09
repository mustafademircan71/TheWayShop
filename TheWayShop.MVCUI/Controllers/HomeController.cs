using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Common;
using Microsoft.AspNetCore.Mvc;
using TheWayShop.Business.Abstract;
using TheWayShop.Model.Entity;
using TheWayShop.Model.ViewModels.Shop;

namespace TheWayShop.MVCUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessageBs _messageBs;
        public HomeController(IMessageBs messageBs)
        {
            _messageBs = messageBs;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(NewMessageVm vm)
        {
            if (!ModelState.IsValid)
            {
                string errorMessages = "";
                foreach (var value in ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        errorMessages += error.ErrorMessage + "<br />";
                    }
                }
                return Json(new { Result = false, Message = errorMessages });
            }
            Message message = new Message();

            message.Id = vm.Id;
            message.IsActive = true;
            message.FullName = vm.FullName;
            message.Mail = vm.Mail;
            message.Subject = vm.Subject;
            message.Messages = vm.Messages;
            string mailMessage = $"Sayın {message.FullName} Mesajınız Alınmıştır En Yakın Sürede Size Bilgi verilecektir.";
            MailSender.Send(message.Mail, message.Subject, mailMessage);
            _messageBs.Insert(message);


            return Json(new { Result = true, Message = "Mesaj Gönderildi" });

        }
    }
}
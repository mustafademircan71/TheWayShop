using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Common;
using Microsoft.AspNetCore.Mvc;
using TheWayShop.Business.Abstract;
using TheWayShop.Model.Entity;
using TheWayShop.Model.Enums;
using TheWayShop.Model.ViewModels.AdminPanel;
using TheWayShop.MVCUI.Aspects;

namespace TheWayShop.MVCUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [SessionAspect]
    [RoleAspect((int)AdminRoles.SuperAdmin)]
    public class MessageListController : Controller
    {
        private readonly IMessageBs _messageBs;
        private readonly ISendMessageBs _sendMessageBs;
        public MessageListController(IMessageBs messageBs, ISendMessageBs sendMessageBs)
        {
            _messageBs = messageBs;
            _sendMessageBs = sendMessageBs;
        }
        [HttpGet]
        public IActionResult List()
        {
            List<Message> messages = _messageBs.MessagesList();


            return View(messages);
        }
        [HttpGet]
        public IActionResult SendMessageList()
        {
            List<SendMessage> messages = _sendMessageBs.SendMessageList();

            return View(messages);
        }
        [HttpPost]
        public IActionResult MessageDetails(int id)
        {
            Message message = _messageBs.MessageById(id);

            MessageDetailsVm vm = new MessageDetailsVm();

            vm.Email = message.Mail;
            vm.Id = message.Id;
            vm.FullName = message.FullName;
            vm.Subject = message.Subject;
           

            return Json(new { MessageInfo = vm });
        }
        [HttpPost]
        public IActionResult NewMessage(NewMessageAdminVm vm)
        {
            SendMessage send = new SendMessage();
            send.Email = vm.Mail;
            send.IsActive = true;
            send.FullName = vm.FullName;
            send.Subject = vm.Subject;
            send.Messages = vm.Messages;
            _sendMessageBs.Insert(send);
            string mailMessage = $"Sayın {send.FullName} {send.Messages}";
            MailSender.Send(send.Email, send.Subject, mailMessage);
            return Json(new { Result = true, Message = "Mesaj Gönderildi" });
            
        }
        [HttpPost]
        public IActionResult MessageDelete(int id)
        {
            _messageBs.Delete(id);

            return Json(new { Result = true, Message = "Başarıyla Silindi" });
        }
        [HttpPost]
        public IActionResult SendMessageDelete(int id)
        {
            _sendMessageBs.Delete(id);
            return Json(new { Result = true, Message = "Başarıyla Silindi" });
        }
    }
}

using Core.Utilities.Common;
using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Business.Abstract;
using TheWayShop.DataAccess.Abstract;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Concrete
{
    public class SendMessageBs : ISendMessageBs
    {
        private readonly ISendMessageRepository _repo;
        public SendMessageBs(ISendMessageRepository repo)
        {
            _repo = repo;
        }

        public void Delete(int id)
        {
            _repo.DeleteNoActive(id);
        }

        public void Insert(SendMessage sendMessage)
        {
            _repo.Insert(sendMessage);
        }

        

        public List<SendMessage> SendMessageList(params string[] includeList)
        {
            return _repo.GetAll();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Business.Abstract;
using TheWayShop.DataAccess.Abstract;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Concrete
{
    public class MessageBs : IMessageBs
    {
        private readonly IMessageRepository _repo;
        public MessageBs(IMessageRepository repo)
        {
            _repo = repo;
        }

        public void Delete(int id)
        {
            _repo.DeleteNoActive(id);
        }

        public void Insert(Message message)
        {
            _repo.Insert(message);
        }

        public Message MessageByEmail(string email)
        {
            return _repo.Get(x => x.Mail == email);
        }

        public Message MessageById(int id)
        {
            return _repo.GetById(id);
           
        }

        public List<Message> MessagesList(params string[] includeList)
        {
           return  _repo.GetAll();
        }
    }
}

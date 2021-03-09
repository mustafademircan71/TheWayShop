using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Abstract
{
    public interface IMessageBs
    {
        List<Message> MessagesList(params string[] includeList);
        Message MessageById(int id);
        void Insert(Message message);
        Message MessageByEmail(string email);
        void Delete(int id);

         


        
    
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Abstract
{
    public interface ISendMessageBs
    {
        List<SendMessage> SendMessageList(params string[] includeList);
        void Insert(SendMessage sendMessage);

        void Delete(int id);
     
    }
}

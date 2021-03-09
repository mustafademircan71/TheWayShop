using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheWayShop.Model.Entity
{
    public class Message:BaseEntity
    {
        public string FullName { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Messages { get; set; }
    }
}

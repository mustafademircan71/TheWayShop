using System;
using System.Collections.Generic;
using System.Text;

namespace TheWayShop.Model.ViewModels.AdminPanel
{
    public class NewMessageVm
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Mail { get; set; }
        public string Message { get; set; }

        public string Subject { get; set; }
    }
}

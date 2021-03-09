using System;
using System.Collections.Generic;
using System.Text;

namespace TheWayShop.Model.ViewModels.AdminPanel
{
    public class SliderDeleteVm
    {
        public int Id { get; set; }
        public string SliderImage { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public bool IsActive { get; set; }
    }
}

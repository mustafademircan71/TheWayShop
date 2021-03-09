using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheWayShop.Model.Entity
{
     public class Slider:BaseEntity
    {
        public string SliderImage { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }
}

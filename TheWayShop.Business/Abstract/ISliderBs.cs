using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Abstract
{
     public interface ISliderBs
    {
        List<Slider> ListSlider(params string[] includeList);
        Slider SliderById(int id, params string[] includeList);
        void Update(Slider slider);
        void Insert(Slider slider);
        void Delete(int sliderId);
        void DeleteNoActive(int id);
        
    }
}

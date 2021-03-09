using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheWayShop.Business.Abstract;
using TheWayShop.Model.Entity;

namespace TheWayShop.MVCUI.Components
{
    public class IndexPageSliderViewComponent:ViewComponent
    {
        private readonly ISliderBs _sliderBs;

        public IndexPageSliderViewComponent(ISliderBs sliderBs)
        {
            _sliderBs = sliderBs;
        }

        public IViewComponentResult Invoke()
        {
            List<Slider> sliders = _sliderBs.ListSlider();

            return View(sliders);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Business.Abstract;
using TheWayShop.DataAccess.Abstract;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Concrete
{
    public class SliderBs : ISliderBs
    {
        private readonly ISliderRepository _repo;
        public SliderBs(ISliderRepository repo)
        {
            _repo = repo;
        }
        public void Delete(int sliderId)
        {
            _repo.Delete(sliderId);
        }

        public void DeleteNoActive(int id)
        {
            _repo.DeleteNoActive(id);
        }

        public void Insert(Slider slider)
        {
            _repo.Insert(slider);
        }

        public List<Slider> ListSlider(params string[] includeList)
        {
            return _repo.GetAll(filter: null,
                includeList: includeList);
            
        }

        public Slider SliderById(int id, params string[] includeList)
        {
            return _repo.GetById(id, includeList);
        }

        public void Update(Slider slider)
        {
            _repo.Update(slider);
        }
    }
}

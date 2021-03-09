using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.Model.Entity;

namespace TheWayShop.Business.Abstract
{
    public interface  IViewedProductBs
    {
        List<ViewedProduct> ViewedProductList(params string[] includeList);
        void Insert(ViewedProduct viewedProduct);
    }
}

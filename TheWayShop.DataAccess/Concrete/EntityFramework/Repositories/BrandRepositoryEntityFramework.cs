﻿using Core.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using TheWayShop.DataAccess.Abstract;
using TheWayShop.DataAccess.Concrete.EntityFramework.Contexts;
using TheWayShop.Model.Entity;

namespace TheWayShop.DataAccess.Concrete.EntityFramework.Repositories
{
    public class BrandRepositoryEntityFramework : RepositoryEntityFramework<Brand, TheWayShopDbContext>, IBrandRepository
    {
    }
}

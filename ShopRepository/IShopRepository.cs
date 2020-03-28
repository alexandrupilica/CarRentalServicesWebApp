using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDSCar.Repositories.ShopRepository
{
    interface IShopRepository
    {
        List<Shop> GetAll();
        Shop Get(int Id);
        Shop Create(Shop Shop);
        Shop Update(Shop Shop);
        Shop Delete(Shop Shop);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDSCar.Repositories.CarRepository
{
    interface ICarRepository
    {
        List<Car> GetAll();
        Car Get(int Id);
        Car Create(Car Car);
        Car Update(Car Car);
        Car Delete(Car Car);
    }
}

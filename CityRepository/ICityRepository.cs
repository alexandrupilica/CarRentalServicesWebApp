using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDSCar.Repositories.CityRepository
{
    interface ICityRepository
    {
        List<City> GetAll();
        City Get(int Id);
        City Create(City City);
        City Update(City City);
        City Delete(City City);


    }
}

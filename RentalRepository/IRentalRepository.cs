﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDSCar.Repositories.RentalRepository
{
    interface IRentalRepository
    {
        List<Rental> GetAll();
        Rental Get(int Id);
        Rental Create(Rental Rental);
        Rental Update(Rental Rental);
        Rental Delete(Rental Rental);
    }
}

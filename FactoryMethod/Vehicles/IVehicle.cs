﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicles
{
    public interface IVehicle
    {
        void GetCargo();
        void StartRoute();
    }
}

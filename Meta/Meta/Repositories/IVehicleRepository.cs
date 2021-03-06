﻿using Meta.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meta.Repositories
{
    public interface IVehicleRepository
    {
        Vehicle Create(Vehicle item);
        void Delete(Vehicle item);
        Vehicle Edit(Vehicle item);
        Vehicle Find(Guid id);
        Vehicle Find(string series, uint number);

        IEnumerable<Vehicle> List();
    }
}

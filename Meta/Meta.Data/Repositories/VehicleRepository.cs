using Meta.Domain;
using Meta.Repositories;
using System;
using System.Collections.Generic;

namespace Meta.Data.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        public Vehicle Create(Vehicle item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Vehicle Edit(Vehicle item)
        {
            throw new NotImplementedException();
        }

        public Vehicle Find(Guid id)
        {
            throw new NotImplementedException();
        }

        public Vehicle Find(string series, uint number)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vehicle> List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vehicle> List(string chassis)
        {
            throw new NotImplementedException();
        }
    }
}

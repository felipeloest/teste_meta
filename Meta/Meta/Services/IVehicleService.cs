using Meta.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meta.Services
{
    public interface IVehicleService
    {
        Vehicle Create(VehicleType type, string color, string series, uint number);
        void Delete(Guid id);
        Vehicle Edit(Guid id, string color);
        Vehicle Find(string series, uint number);

        IEnumerable<Vehicle> List();
    }
}

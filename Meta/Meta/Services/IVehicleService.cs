using Meta.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meta.Services
{
    public interface IVehicleService
    {
        Vehicle Create();
        void Delete();
        Vehicle Edit();
        Vehicle Find();

        IEnumerable<Vehicle> List();
        IEnumerable<Vehicle> List(string chassis);
    }
}

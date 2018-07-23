using System;
using System.Collections.Generic;
using System.Text;

namespace Meta.Domain
{
    public class Vehicle : Entity
    {
        public string Color { get; set; }

        public VehicleType Type { get; set; }

        public virtual Chassis Chassis { get; set; }
    }
}

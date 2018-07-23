using System;
using System.Collections.Generic;
using System.Text;

namespace Meta.Domain
{
    public class Vehicle : Entity
    {
        protected Vehicle() { }
        public Vehicle(VehicleType type, string series, uint number)
        {
            this.Type = type;
            this.Chassis = new Chassis(this, series, number);
        }

        public VehicleType Type { get; set; }

        public string Color { get; set; }
        public virtual Chassis Chassis { get; set; }
    }
}

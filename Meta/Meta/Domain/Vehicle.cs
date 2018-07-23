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
            if (string.IsNullOrWhiteSpace(series))
                throw new ArgumentException("value canot be empity!", "vehicle");

            this.Type = type;
            this.Chassis = new Chassis(this, series, number);
        }

        public VehicleType Type { get; protected set; }
        public virtual Chassis Chassis { get; protected set; }

        public string Color { get; set; }
    }
}

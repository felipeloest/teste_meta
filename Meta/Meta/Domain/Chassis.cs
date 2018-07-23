using System;
using System.Collections.Generic;
using System.Text;

namespace Meta.Domain
{
    public class Chassis : Entity
    {
        protected Chassis() { }
        public Chassis(Vehicle vehicle, string series, uint number)
        {
            if (vehicle == null)
                throw new ArgumentNullException("vehicle");
            if(string.IsNullOrWhiteSpace(series))
                throw new ArgumentException("value canot be empity!", "vehicle");

            Vehicle = vehicle;
            Series = series;
            Number = number;
        }

        public string Series { get; protected set; }
        public uint Number { get; protected set; }

        public Vehicle Vehicle { get; protected set; }
    }
}

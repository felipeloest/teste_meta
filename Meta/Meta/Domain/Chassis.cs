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
            this.Vehicle = vehicle;
            Series = series;
            Number = number;
        }

        public string Series { get; set; }
        public uint Number { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}

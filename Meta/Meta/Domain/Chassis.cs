using System;
using System.Collections.Generic;
using System.Text;

namespace Meta.Domain
{
    public class Chassis : Entity
    {
        public string Series { get; set; }
        public uint Number { get; set; }
    }
}

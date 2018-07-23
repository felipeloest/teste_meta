using Meta.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Meta.Context.Mappings
{
    internal class ChassisMapping : EntityTypeConfiguration<Chassis>
    {
        public ChassisMapping()
        {
            this.Property(x => x.Number);
            this.Property(x => x.Series);
        }
    }
}

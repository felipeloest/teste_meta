using Meta.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Meta.Context.Mappings
{
    internal class VehicleMapping : EntityTypeConfiguration<Vehicle>
    {
        public VehicleMapping()
        {
            this.Property(x => x.Color);
            this.HasRequired(x => x.Chassis);
        }
    }
}

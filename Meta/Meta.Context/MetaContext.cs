using Meta.Domain;
using System;
using System.Data.Entity;

namespace Meta.Context
{
    public class MetaContext : DbContext
    {
        public MetaContext()
        {
        }

        public DbSet<Chassis> Chassis { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

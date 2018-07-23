using Meta.Context;
using Meta.Domain;
using Meta.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Meta.Data.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly MetaContext Context;

        public VehicleRepository(MetaContext context)
        {
            this.Context = context;
        }

        public Vehicle Create(Vehicle item)
        {
            if (item == null)
                throw new ArgumentNullException("item");

            Context.Vehicle.Add(item);
            Context.SaveChanges();

            return item;
        }

        public void Delete(Vehicle item)
        {
            if (item == null)
                throw new ArgumentNullException("item");

            Context.Vehicle.Remove(item);
            Context.SaveChanges();
        }

        public Vehicle Edit(Vehicle item)
        {
            if (item == null)
                throw new ArgumentNullException("item");

            Context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();

            return item;
        }

        public Vehicle Find(Guid id)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var item = Context.Vehicle.Find(id);
            return item;
        }

        public Vehicle Find(string series, uint number)
        {
            var query = Context.Vehicle.Where(x => x.Chassis.Series == series && x.Chassis.Number == number);
            var item = query.SingleOrDefault();

            return item;
        }

        public IEnumerable<Vehicle> List()
        {
            var items = Context.Vehicle.ToList();
            return items;
        }
    }
}

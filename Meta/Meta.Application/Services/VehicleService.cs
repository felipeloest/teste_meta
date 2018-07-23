using Meta.Domain;
using Meta.Repositories;
using Meta.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meta.Application.Services
{
    public class VehicleService : IVehicleService
    {
        private static NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly IVehicleRepository VehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            this.VehicleRepository = vehicleRepository;
        }

        public Vehicle Create(VehicleType type, string color, string series, uint number)
        {
            try
            {
                if (this.VehicleRepository.Find(series, number) != null)
                    throw new InvalidOperationException("Unable to create a new vehicle, the chassis already exists!");

                var item = new Vehicle(type, series, number)
                {
                    Color = color
                };

                this.VehicleRepository.Create(item);
                return item;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                throw;
            }
        }

        public void Delete(Guid id)
        {
            try
            {
                var item = this.VehicleRepository.Find(id);
                if (item == null)
                    throw new KeyNotFoundException(string.Format("Vehicle not foud! Id{0}", id));

                this.VehicleRepository.Delete(item.Id);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                throw;
            }
        }

        public Vehicle Edit(Guid id, string color)
        {
            try
            {
                var item = this.VehicleRepository.Find(id);
                if (item == null)
                    throw new KeyNotFoundException(string.Format("Vehicle not foud! Id{0}", id));

                item.Color = color;

                this.VehicleRepository.Edit(item);
                return item;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                throw;
            }
        }

        public Vehicle Find(string series, uint number)
        {
            var item = this.VehicleRepository.Find(series, number);
            return item;
        }

        public IEnumerable<Vehicle> List()
        {
            var items = this.VehicleRepository.List();
            return items;
        }
    }
}

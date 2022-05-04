using System;
using VehiclesManagementSystem.Models.Vehicle;

namespace VehiclesManagementSystem.Models.VehicleFactory.Vehicle
{
    public abstract class IVehicle   
    {

        public Guid vechicleGuid { get; set; }  
        public string vehicleType{ get; set; }

        public double noOftires { get; set; }
      
        public bool isAvailableVehicle { get; set; }

        public abstract string CreateVehicle();

  




    }
}

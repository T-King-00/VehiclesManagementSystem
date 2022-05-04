using VehiclesManagementSystem.Models.VehicleFactory.Vehicle;

namespace VehiclesManagementSystem.Models.VehicleFactory
{
    public class Bike : IVehicle
    {

        public override string CreateVehicle()
        {
            return "Bike is created";
        }
    }
}

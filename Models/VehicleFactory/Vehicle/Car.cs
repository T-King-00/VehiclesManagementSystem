using VehiclesManagementSystem.Models.Vehicle;
using VehiclesManagementSystem.Models.VehicleFactory.Vehicle;


namespace VehiclesManagementSystem.Models.VehicleFactory
{
    public class Car : IVehicle
    { 
        public override  string CreateVehicle()
        {

            return "Car is created ";
        }
    }
}

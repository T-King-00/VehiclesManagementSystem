using VehiclesManagementSystem.Models.VehicleFactory.Vehicle;

namespace VehiclesManagementSystem.Models.VehicleFactory
{
    public class Bus : IVehicle
    {

        public override string CreateVehicle()
        {
            return "Bus is created";
        }
    }
}

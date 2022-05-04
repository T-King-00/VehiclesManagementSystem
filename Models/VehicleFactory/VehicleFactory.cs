using VehiclesManagementSystem.Models.Vehicle;
using VehiclesManagementSystem.Models.VehicleFactory.Vehicle;

namespace VehiclesManagementSystem.Models.VehicleFactory
{
    public  class VehicleFactory 
    {
        
        public IVehicle getVehicle(string vehicle)
        {
            if (vehicle.ToLower()=="car")
            {
                return new Car();    
            }
            else if (vehicle.ToLower() == "bus")
            {      
                return new Bus();
            }
            else if (vehicle.ToLower() == "bike")
            {
                return new Bike();
            }
            return null;
        }



    }
}

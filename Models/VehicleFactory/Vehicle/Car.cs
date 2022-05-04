using VehiclesManagementSystem.Models.Vehicle;
using VehiclesManagementSystem.Models.VehicleFactory.Vehicle;


namespace VehiclesManagementSystem.Models.VehicleFactory
{
    public class Car : IVehicle
    { 
        public override  string CreateVehicle()
        {
            string x;
            x=" Car is created with  : ";
            foreach(AVehicleComponent item in vehicleCompositeList)
            {
                x+=  item.componentName + " / ";
            }
          
            return x;
        }
    }
}

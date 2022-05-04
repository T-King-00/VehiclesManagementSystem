using VehiclesManagementSystem.Models.VehicleFactory.Vehicle;

namespace VehiclesManagementSystem.Models.VehicleFactory.decorater
{
    public class SportsCar : CarDecorater
    {
       
        public SportsCar(Car decoratedCar) : base(decoratedCar)
        {
          this.decoratedCar = decoratedCar;
        }
        public override string CreateVehicle()
        {
            
            return this.setSportsEngine();
        }

        public string setSportsEngine()
        {
            return "    Sets sports engine for a  car";
        }



    }
}

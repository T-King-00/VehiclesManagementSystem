using VehiclesManagementSystem.Models.VehicleFactory.Vehicle;

namespace VehiclesManagementSystem.Models.VehicleFactory
{
    public abstract class CarDecorater : Car
    {

        protected Car decoratedCar;

        public CarDecorater(Car decoratedCar)
        {
            this.decoratedCar = decoratedCar;
        }

        public override string CreateVehicle()
        {
            decoratedCar.CreateVehicle();
            return "vehicle created inside decorater";

        }

        public void vehicleDecorater()
        {

        }
        

       


    }
}

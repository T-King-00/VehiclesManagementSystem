using VehiclesManagementSystem.Models.VehicleFactory.Vehicle;

namespace VehiclesManagementSystem.Models.Vehicle
{
    public class VehicleComposite : AVehicleComponent
    {


        public IVehicle car{ get; set; }
    

        public VehicleComposite(IVehicle car,string c   ): base(c)
        {
         
            this.car = car;
            car.vehicleCompositeList = new List<AVehicleComponent>();
        }

         public override void addComponent(AVehicleComponent obj)
        {
            car.vehicleCompositeList.Add(obj);

        }


        public override void deleteComponent(AVehicleComponent obj)
        {
            car.vehicleCompositeList.Remove(obj);
        }


        public override void updateComponent(double Price, string Manufacture, string ComponentName)
        {
            throw new NotImplementedException();
        }


        public override double returnPrice()
        {
            double sum = 0;

            foreach (AVehicleComponent comp in car.vehicleCompositeList)
            {
                sum = sum + comp.returnPrice();

            }
            return sum;
        }

     
    }
}

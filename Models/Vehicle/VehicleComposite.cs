namespace VehiclesManagementSystem.Models.Vehicle
{
    public class VehicleComposite : IvehicleComponent
    {


        public List<IvehicleComponent> vehicleCompositeList { get; set; }


        public VehicleComposite()
        {
            vehicleCompositeList = new List<IvehicleComponent>();
        }

        void IvehicleComponent.addComponent(IvehicleComponent obj)
        {
           vehicleCompositeList.Add(obj);

        }
        List<IvehicleComponent> finishCar()
        {
            return vehicleCompositeList;

        }

        void IvehicleComponent.deleteComponent(IvehicleComponent obj)
        {
            vehicleCompositeList.Remove(obj);
        }


        void IvehicleComponent.updateComponent(double Price, string Manufacture, string ComponentName)
        {
            throw new NotImplementedException();
        }


        double IvehicleComponent.returnPrice()
        {
            double sum = 0;

            foreach (IvehicleComponent comp in vehicleCompositeList)
            {
                sum = sum + comp.returnPrice();

            }
            return sum;
        }

      
    }
}

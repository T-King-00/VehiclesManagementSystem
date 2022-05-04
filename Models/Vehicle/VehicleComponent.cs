using VehiclesManagementSystem.Models.Vehicle;

namespace VehiclesManagementSystem.Models
{
    public class VehicleComponent : IvehicleComponent     //leafObject

    {
        // properties support encapsulation 
        public string ComponentName { get; set; }

        public double Price { get; set; }


        public string Manufacture { get; set; }



        void IvehicleComponent.addComponent(IvehicleComponent obj)
        {
            throw new NotImplementedException();
        }


        void IvehicleComponent.deleteComponent(IvehicleComponent obj)
        {
            throw new NotImplementedException();
        }

        double IvehicleComponent.returnPrice()
        {
            return this.Price;
        }

        void IvehicleComponent.updateComponent(double Price, string Manufacture, string ComponentName)
        {
            this.Price = Price;
            this.Manufacture = Manufacture; 
            this.ComponentName = ComponentName; 
        }
    }
}

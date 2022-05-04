using VehiclesManagementSystem.Models.Vehicle;

namespace VehiclesManagementSystem.Models
{
    public class VehicleComponent : AVehicleComponent     //leafObject

    {
        public VehicleComponent(string componentName) : base(componentName)
        {
            this.componentName = componentName;
        }

        // properties support encapsulation 

        public double Price { get; set; }
        public string Manufacture { get; set; }

        public override void addComponent(AVehicleComponent obj)
        {
            throw new NotImplementedException();
        }

        public override void deleteComponent(AVehicleComponent obj)
        {
            throw new NotImplementedException();
        }


        public override double returnPrice()
        {
            return this.Price;
        }

        public override void updateComponent(double Price, string Manufacture, string ComponentName)
        {
            this.Price = Price;
            this.Manufacture = Manufacture; 
            this.componentName = ComponentName; 
        }
    }
}

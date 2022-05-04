namespace VehiclesManagementSystem.Models.Vehicle
{
    public abstract class AVehicleComponent
    {
        protected AVehicleComponent(string componentName)
        {
            this.componentName = componentName;
        }

        public  string componentName { get; set; } 
        public abstract void addComponent(AVehicleComponent obj);
        public abstract void deleteComponent(AVehicleComponent obj);
        public abstract void updateComponent(double Price, string Manufacture, string ComponentName);

        public abstract double returnPrice();



    }
}

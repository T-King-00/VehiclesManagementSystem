namespace VehiclesManagementSystem.Models.Vehicle
{
    public interface IvehicleComponent
    {

        public void addComponent(IvehicleComponent obj);
        public void deleteComponent(IvehicleComponent obj);
        public void updateComponent(double Price, string Manufacture, string ComponentName);

        public double returnPrice();



    }
}

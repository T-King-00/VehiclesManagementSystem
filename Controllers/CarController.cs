using VehiclesManagementSystem.Models;
using VehiclesManagementSystem.Models.Vehicle;
using Microsoft.AspNetCore.Mvc;
using VehiclesManagementSystem.Models.VehicleFactory;
using VehiclesManagementSystem.Models.VehicleFactory.Vehicle;
using VehiclesManagementSystem.Models.VehicleFactory.decorater;

namespace VehiclesManagementSystem.Controllers
{
    public class CarController : Controller
    { 
        public ActionResult Index()
        {


            VehicleFactory Factory = new VehicleFactory();

            IVehicle carObj = Factory.getVehicle("Car");





            AVehicleComponent door = new VehicleComponent("door")
            {
               
                Price = 100,
                Manufacture = "bmw"
               
            
            };
            AVehicleComponent glass = new VehicleComponent("glass")
            {
               
                Price = 5000,
                Manufacture = "axy"

            };

            AVehicleComponent loock = new VehicleComponent("lock")
            {
               
                Price = 1000,
                Manufacture = "xyx"
            };


            AVehicleComponent car = new VehicleComposite(carObj,"carObj");
          

            car.addComponent(door);
            car.addComponent(glass);
            car.addComponent(loock);

            
            ViewBag.emptyString=car.returnPrice();

            Console.WriteLine(carObj.CreateVehicle());
        






            return View();
        }
    }
}

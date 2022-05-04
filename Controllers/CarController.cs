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

            Console.WriteLine(carObj.CreateVehicle());



            IvehicleComponent door = new VehicleComponent()
            {
                ComponentName = "Door",
                Price = 100,
                Manufacture = "bmw"
               
            
            };
            IvehicleComponent glass = new VehicleComponent()
            {
                ComponentName = "glass",
                Price = 5000,
                Manufacture = "axy"

            };

            IvehicleComponent loock = new VehicleComponent()
            {
                ComponentName = "lock",
                Price = 1000,
                Manufacture = "xyx"
            };


            IvehicleComponent car = new VehicleComposite();
          

            car.addComponent(door);
            car.addComponent(glass);
            car.addComponent(loock);


            ViewBag.emptyString=car.returnPrice();

            

    








            return View();
        }
    }
}

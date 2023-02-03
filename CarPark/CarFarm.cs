using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    internal class CarFarm
    {
        List<Vehicle> vehiclesInPark;
        public void CreateAutoPark()
        {
            Engine carEngine = new Engine(120, 2.4, "diesel", "4Fde856");
            Engine truckEngine = new Engine(500, 8.9, "petrol", "81HgtF5");
            Engine scooterEngine = new Engine(60, 0.2, "petrol", "54ScooT6");
            Engine busEngine = new Engine(240, 5.6, "gas", "52buS61F");

            Chasses chasses1 = new Chasses(4, 5060, 1200);
            Chasses chasses2 = new Chasses(6, 5608, 1600);
            Chasses chasses3 = new Chasses(8, 6950, 1900);
            Chasses chasses4 = new Chasses(10, 7128, 2200);
            Chasses chasses5 = new Chasses(2, 6512, 200);

            Transmission transmission1 = new Transmission("Automatic Transmission", 5, "Borgwarner Inc.");
            Transmission transmission2 = new Transmission("Manual Transmission", 6, "Aw North Carolina, Inc.");
            Transmission transmission3 = new Transmission("Automated Manual Transmission", 5, "Dana Inc.");

            vehiclesInPark = new List<Vehicle>() {
                new Car("Opel", carEngine, transmission1, chasses1),
                new Truck("Mersedes", truckEngine, transmission2, chasses4),
                new Scooter("Honda Activa 6G", scooterEngine, transmission3, chasses5),
                new Bus("Icarus", busEngine, transmission2, chasses3)
            };
            
        }
        public void GetTheVehicleList() {
            foreach (var vehicle in vehiclesInPark)
            {
                Console.WriteLine($"Vehicle's name: {vehicle.Name}; Engine: {vehicle.Engine}; Transmission: {vehicle.Transmission}; Chasses: {vehicle.Chasses}; Vehicle Type: {vehicle.VehicleType}");
            }
            
        }
    }
}

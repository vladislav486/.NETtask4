using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPark.VehicleDetails;

namespace CarPark.Vehicles
{
    internal class Car : Vehicle
    {
        public Car(string name, Engine engine, Transmission transmission, Chasses chasses) : base(name, engine, transmission, chasses)
        {
            VehicleType = "Passenger Car";
        }
    }

}

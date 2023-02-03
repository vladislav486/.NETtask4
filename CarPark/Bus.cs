using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    internal class Bus : Vehicle
    {
        public Bus(string name, Engine engine, Transmission transmission, Chasses chasses) : base(name, engine, transmission, chasses)
        {
            this.VehicleType = "Public Vehicle";
        }
    }
}

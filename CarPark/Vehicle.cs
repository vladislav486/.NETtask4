using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    internal abstract class Vehicle
    {
        protected Vehicle(string name, Engine engine, Transmission transmission, Chasses chasses)
        {
            Name = name;
            Engine = engine;
            Transmission = transmission;
            Chasses = chasses;
        }


        public string Name { get; }
        public Engine Engine { get; set; }
        public Transmission Transmission { get; set; }
        public Chasses Chasses { get; set; }
        public string VehicleType { get; protected set; }

        public void TurnOnEngine() 
        {
        
        }

    }
}

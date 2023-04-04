using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.VehicleDetails
{
    class Chasses
    {
        public Chasses(int numberOfWheels, int number, int loadCapacity)
        {
            if (numberOfWheels <= 0)
                throw new Exception($"Sorry, the vehicle cannot be created with {numberOfWheels} amount of wheels. Please check the input");
            
            NumberOfWheels = numberOfWheels;
            Number = number;
            LoadCapacity = loadCapacity;
        }

        public int NumberOfWheels { get; }
        public int Number { get; }
        public int LoadCapacity { get; }

        public override string ToString()
        {
            return $"Number of wheels: {NumberOfWheels}, Chasses number: {Number}, Chasses load capacity: {LoadCapacity}";
        }
    }
}

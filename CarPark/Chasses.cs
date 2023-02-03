using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    class Chasses
    {
        public Chasses(int numberOfWheels, int number, int loadCapacity)
        {
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

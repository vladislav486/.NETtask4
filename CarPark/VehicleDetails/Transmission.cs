using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.VehicleDetails
{
    class Transmission
    {
        public Transmission(string type, int numberOfGears, string manufacturer)
        {
            Type = type;
            if (numberOfGears <= 0)
                throw new Exception($"Sorry, the number of gears cannot be '{numberOfGears}'. Please check the input.");

            NumberOfGears = numberOfGears;
            Manufacturer = manufacturer;
        }

        public string Type { get; }
        public int NumberOfGears { get; }
        public string Manufacturer { get; }

        public override string ToString()
        {
            return $"Transmission type: {Type}, Number of gears: {NumberOfGears}, Transmission manufacturer: {Manufacturer}";
        }
    }
}

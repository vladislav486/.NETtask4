﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    class Engine
    {

        public Engine(int power, double volume, string type, string serialNumber)
        {
            Power = power;
            Volume = volume;
            Type = type;
            SerialNumber = serialNumber;
        }

        public int Power { get; set; }
        public double Volume { get; set; }
        public string Type { get; }

        public string SerialNumber { get; }

        public override string ToString()
        {
            return $"Engine type: {Type}, Engine power: {Power}, Engine volume: {Volume}";
        }
    }
}

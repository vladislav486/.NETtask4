using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CarPark {
    public class Program {

        static void Main(string[] args)
        {
            var instance = new CarFarm();
            instance.CreateAutoPark();
            instance.GetTheVehicleList();
        }
    }
}

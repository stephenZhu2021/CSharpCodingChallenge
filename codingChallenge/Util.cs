using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingChallenge
{
    internal class Util
    {
        // output function
        public static void OutputMessage(IVehicle vehicle, int vehicleNumber, string specialProperty, string specialPropertyValue)
        {
            Console.WriteLine("Vehicle {0}: {1}", vehicleNumber++, vehicle.GetType().Name);
            Console.WriteLine("{0,-20} {1,-15} {2,-15} {3,-15} {4,-20} {5,-15}", "Manufacturer", "Model",
                "Color", "Year Built", "Age of Vehicle", specialProperty);
            Console.WriteLine("{0,-20} {1,-15} {2,-15} {3,-15} {4,-20} {5,-15}", vehicle.Manufacturer, vehicle.Model,
                vehicle.Color, vehicle.YearBuild, vehicle.Calculate(), specialPropertyValue);
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace codingChallenge
{
    internal class ElectricVehicle : VehicleImp
    {
        private string _motorType;
        public string MotorType { get => _motorType; set => _motorType = value; }

        public override void ShowMessage()
        {
            Console.WriteLine($"Vehicle type: Electric Vehicle");
            Console.WriteLine("{0,-20} {1,-15} {2,-15} {3,-15} {4,-20} {5,-15}", "Manufacturer", "Model",
                "Color", "Year Built", "Age of Vehicle", "Motor Type");
            Console.WriteLine("{0,-20} {1,-15} {2,-15} {3,-15} {4,-20} {5,-15}", Manufacturer, Model,
                Color, YearBuild, Calculate(), MotorType);
            Console.WriteLine();
        }
    }
}
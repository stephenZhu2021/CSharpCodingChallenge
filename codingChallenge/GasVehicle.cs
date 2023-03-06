using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingChallenge
{
    internal class GasVehicle : VehicleImp
    {
        private string _engineSize;
        public string EngineSize { get => _engineSize; set => _engineSize = value; }

        public override void ShowMessage()
        {
            Console.WriteLine($"Vehicle type: Gas Vehicle");
            Console.WriteLine("{0,-20} {1,-15} {2,-15} {3,-15} {4,-20} {5,-15}", "Manufacturer", "Model",
                "Color", "Year Built", "Age of Vehicle", "Engine Size");
            Console.WriteLine("{0,-20} {1,-15} {2,-15} {3,-15} {4,-20} {5,-15}", Manufacturer, Model,
                Color, YearBuild, Calculate(), EngineSize);
            Console.WriteLine();
        }
    }
}

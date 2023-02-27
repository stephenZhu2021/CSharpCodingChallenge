using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingChallenge
{
    public interface IVehicle
    {
        string Color { get; set; }

        string Manufacturer { get; set; }

        string Model { get; set; }

        int YearBuild { get; set; }

        int Calculate();
    }
}

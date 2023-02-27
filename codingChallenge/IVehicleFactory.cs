using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingChallenge
{
    internal interface IVehicleFactory
    {
        List<IVehicle> GenerateVehicles(int n);
        IVehicle GenerateVehicle();
    }
}

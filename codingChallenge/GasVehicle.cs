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
    }
}

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
    }
}
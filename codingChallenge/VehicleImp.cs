using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingChallenge
{
    public abstract class VehicleImp : IVehicle
    {
        private string _color;
        public string Color { get => _color; set => _color = value; }

        private string _manufacturer;
        public string Manufacturer { get => _manufacturer; set => _manufacturer = value; }

        private string _model;
        public string Model { get => _model; set => _model = value; }

        private int _yearBuild;
        public int YearBuild { get => _yearBuild; set => _yearBuild = value; }
        public int Calculate()
        {
            return DateTime.Now.Year - YearBuild;
        }
        public abstract void ShowMessage();
    }
}

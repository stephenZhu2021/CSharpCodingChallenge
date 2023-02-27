using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace codingChallenge
{
    internal class VehicleFactory : IVehicleFactory
    {
        private readonly string[] manufacturerList = { "Toyota", "Ford", "Honda" };
        private readonly string[] colorList = { "red", "black", "silver" };
        private readonly string[] modelList = { "Sedan", "SUV", "Van", "Jeep" };
        private readonly int[] yearList = { 2018, 2019, 2020, 2021, 2022 };
        private readonly string[] engineSizeList = { "Four cylinders", "Six cylinders", "Eight cylinders" };
        private readonly string[] motorTypeList = { "Single", "Dual" };
        private readonly Random random = new();

        // Generate a list of randome vehicles based on the number passed in
        public List<IVehicle> GenerateVehicles(int n)
        {
            List<IVehicle> vehicles = new();
            for (int i = 0; i < n; i++)
            {
                vehicles.Add(GenerateVehicle());
            }
            return vehicles;
        }

        // Generate 1 random vehicle
        public IVehicle GenerateVehicle()
        {
            var runningAssembly = Assembly.GetExecutingAssembly();
            var vehicleType = typeof(VehicleImp);
            var allVehicleTypes = new List<Type>();
            foreach (var type in runningAssembly.GetTypes())
            {
                if(vehicleType.IsAssignableFrom(type) && type != vehicleType)
                {
                    allVehicleTypes.Add(type);
                }
            }
            var selectedType = allVehicleTypes[random.Next(allVehicleTypes.Count)];
            IVehicle vehicle = AddProperties((IVehicle)Activator.CreateInstance(selectedType));
            return vehicle;
        }

        private IVehicle AddProperties(IVehicle v)
        {
            v.Manufacturer = manufacturerList[random.Next(manufacturerList.Length)];
            v.Model = modelList[random.Next(modelList.Length)];
            v.Color = colorList[random.Next(colorList.Length)];
            v.YearBuild = yearList[random.Next(yearList.Length)];
            if(v is GasVehicle gas)
            {
                gas.EngineSize = engineSizeList[random.Next(engineSizeList.Length)];
            }else if(v is ElectricVehicle electric)
            {
                electric.MotorType = motorTypeList[random.Next(motorTypeList.Length)];
            }
            return v;
        }
    }
}

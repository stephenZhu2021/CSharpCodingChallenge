using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace codingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // generate a list of 10 vehicles
            VehicleFactory factory = new();
            List<IVehicle> vehicleList = factory.GenerateVehicles(10);

            // sort vehicle list
            List<IVehicle> sortedList = vehicleList.OrderBy(a => a.GetType().Name).ToList();

            // output to the console
            int vehicleNumber = 1;
            foreach (IVehicle vehicle in sortedList)
            {
                if(vehicle is GasVehicle gas)
                {
                    Util.OutputMessage(gas, vehicleNumber++, "Engine Size", gas.EngineSize);
                }
                else if(vehicle is ElectricVehicle electric)
                {
                    Util.OutputMessage(electric, vehicleNumber++, "Motor Type", electric.MotorType);
                }
            }
        }
    }
}
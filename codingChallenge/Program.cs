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
            foreach (IVehicle vehicle in sortedList)
            {
                vehicle.ShowMessage();
            }
        }
    }
}
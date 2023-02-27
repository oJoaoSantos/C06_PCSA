using E01_OOP_Interfaces_Veiculo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E01_OOP_Interfaces_Veiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUniCodeConsole();

            #region Intantiate
            Airplane airplane = new Airplane(1, "Airplane", "Airbus A330", Airplane.EnumFuel.Avgas);
            Car car = new Car(1, "Car", "Renault Megane", Car.EnumColor.Grey);
            Submarine submarine = new Submarine(1, "Submarine", "Some Model", true);
            #endregion

            #region Run
            Utility.WriteTitle("Airplane");
            airplane.Register();
            airplane.Fly();
            airplane.Terminate();
            Console.WriteLine("\n");

            Utility.WriteTitle("Car");
            car.Register();
            car.Drive();
            car.Terminate();
            Console.WriteLine("\n");

            Utility.WriteTitle("Submarine");
            submarine.Register();
            submarine.Dive();
            submarine.Terminate();
            #endregion

            Utility.TerminateConsole();
        }
    }
}

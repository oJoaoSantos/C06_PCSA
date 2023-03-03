using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace E02_OOP_Collections_Car.Classes
{
    internal class Car
    {
        #region Enumerations
        public enum EnumBrand
        {
            Bólide,
            Mercedes,
            BMW
        }
        public enum EnumModel
        {
            Novo_Bólide,
            BólideXpto,
            A220,
            C220,
            d118,
            i420
        }

        public enum EnumColor
        {
            White,
            Black,
            Grey,
            Red,
            Blue
        }
        #endregion

        #region Properties
        public EnumBrand? Brand { get; set; }
        public EnumModel? Model { get; set; }
        public EnumColor? Color { get; set; }
        public string LicensePlate { get; set; }
        public int Displacement { get; set; }
        public int Velocity { get; set; }
        public DateTime RegistrationDate { get; set; }
        #endregion

        #region Constructors
        public Car()
        {
            Brand = null;
            Model = null;
            Color = null;
            LicensePlate = string.Empty;
            Displacement = 0;
            Velocity = 0;
            RegistrationDate = DateTime.MinValue;
        }

        public Car(EnumColor color, string licencePlate, int velocity, DateTime registrationDate, EnumBrand brand = EnumBrand.Bólide, EnumModel model = EnumModel.Novo_Bólide, int displacement = 1000)
        {
            Brand = brand;
            Model = model;
            Color = color;
            LicensePlate = licencePlate;
            Displacement = displacement;
            Velocity = velocity;
            RegistrationDate = registrationDate;
        }

        public Car(EnumBrand brand, EnumModel model, EnumColor color, string licensePlate, int displacement, int velocity, DateTime registrationDate)
        {
            Brand = brand;
            Model = model;
            Color = color;
            LicensePlate = licensePlate;
            Displacement = displacement;
            Velocity = velocity;
            RegistrationDate = registrationDate;
        }

        #region Destructor

        #endregion

        #endregion

        #region Methods

        #region Ask and validate
        internal int AskBrand()
        {
            int count = 1, converted;
            bool success;

            foreach (EnumBrand item in Enum.GetValues(typeof(EnumBrand)))
            {
                Console.WriteLine($"{count++} > {item}");
            }

            do
            {
                Console.Write("Choice: ");
                string choice = Console.ReadLine();
                success = int.TryParse(choice, out converted);
            } while (success == false);
            
            return converted;
        }
        internal int AskModel()
        {
            int count = 1, choice;
            foreach (EnumModel item in Enum.GetValues(typeof(EnumModel)))
            {
                Console.WriteLine($"{count++} > {item}");
            }
            Console.Write("\nChoice: ");
            return choice = int.Parse(Console.ReadLine());
        }
        internal int AskColor()
        {
            int count = 1, choice;
            foreach (EnumColor item in Enum.GetValues(typeof(EnumColor)))
            {
                Console.WriteLine($"{count++} > {item}");
            }
            Console.Write("\nChoice: ");
            return choice = int.Parse(Console.ReadLine());
        }
        internal string AskLicensePlate()
        {
            Console.Write("LicensePlate: ");
            return Console.ReadLine();
        }
        internal string AskDisplacement()
        {
            Console.Write("Displacement: ");
            return Console.ReadLine();
        }
        internal string AskVelocity()
        {
            Console.Write("Velocity: ");
            return Console.ReadLine();
        }
        internal string AskRegistrationDate()
        {
            Console.Write("RegistrationDate: ");
            return Console.ReadLine();
        }
        #endregion

        internal void Stop()
        {

        }

        internal void Acelerate()
        {
        
        }

        internal void Decelerate() 
        { 
        
        }

        internal void ShowList(List<Car> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Brand: {item.Brand}\t Model: {item.Model}\t LicensePlate: {item.LicensePlate}\t Displacement: {item.Displacement}\t Velocity: {item.Velocity}\t Registration Date: {item.RegistrationDate}");
            }
        }
        #endregion
    }
}

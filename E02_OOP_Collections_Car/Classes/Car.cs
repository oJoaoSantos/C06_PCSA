using System;
using System.Collections.Generic;
using D00_Utility;
using E02_OOP_Collections_Car.Interfaces;

namespace E02_OOP_Collections_Car.Classes
{
    internal class Car : ICar
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

        #region Ask and validate Car Properties
        public int AskBrand()
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
        public int AskModel()
        {
            int count = 1, converted;
            bool success;

            foreach (EnumModel item in Enum.GetValues(typeof(EnumModel)))
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
        public int AskColor()
        {
            int count = 1, converted;
            bool success;
            foreach (EnumColor item in Enum.GetValues(typeof(EnumColor)))
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
        public string AskLicensePlate()
        {
            Console.Write("LicensePlate: ");
            return Console.ReadLine();
        }
        public int AskDisplacement()
        {
            Console.Write("Displacement: ");
            return int.Parse(Console.ReadLine());
        }
        public DateTime AskRegistrationDate()
        {
            Console.Write("RegistrationDate: ");
            return Convert.ToDateTime(Console.ReadLine());
        }
        #endregion

        #region Create New car
        public void CreateNewCar(List<Car> car, EnumBrand? brand, EnumModel? model, EnumColor? color, string plate, int disp, DateTime regist)
        {
            car.Add(new Car { Brand = brand, Model = model, Color = color, Displacement= disp, LicensePlate = plate, RegistrationDate = regist});
        }
        #endregion

        #region Stop
        public void Stop(Car car, List<Car> list)
        {
            car.Velocity = 0;
        }
        #endregion

        #region Acelerate
        public void Acelerate(Car car, List<Car> list)
        {
            string comand = "w";
            Utility.WriteTitle("Acelerate");
            Utility.WriteSubTitle("Press 'W' to acelerate");
            ShowVelocity(list);
            do
            {
                comand = Console.ReadLine().ToLower();
                if (comand == "w")
                {
                    car.Velocity++;
                    ShowVelocity(list);
                }
            } while (comand == "w");
        }
        #endregion

        #region Decelerate
        public void Decelerate(Car car, List<Car> list)
        {
            string comand = "s";
            Utility.WriteTitle("Decelerate");
            Utility.WriteSubTitle("Press 'S' to decelerate");
            ShowVelocity(list);
            do
            {
                comand = Console.ReadLine().ToLower();
                if (comand == "s")
                {
                    car.Velocity--;
                    ShowVelocity(list);
                }
            } while (comand == "s");

        }
        #endregion

        #region Drive
        public void Drive(Car car, List<Car> list)
        {
            string comand = "s";
            Utility.WriteTitle("Drive");
            Utility.WriteSubTitle("Press 'W' to acelerate or 'S' to decelerate");
            ShowVelocity(list);
            do
            {
                comand = Console.ReadLine().ToLower();
                if (comand == "s")
                {
                    car.Velocity--;
                    ShowVelocity(list);
                }
                else if (comand == "w")
                {
                    car.Velocity++;
                    ShowVelocity(list);
                }
            } while (comand == "s" || comand == "w");

        }
        #endregion

        #region Show Lists
        public void ShowList(List<Car> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Brand: {item.Brand}\t Model: {item.Model}\t LicensePlate: {item.LicensePlate}\t Displacement: {item.Displacement}\t Registration Date: {item.RegistrationDate.ToShortDateString()}");
            }
        }
        public void ShowVelocity(List<Car> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Velocity: {item.Velocity}");
            }
        }
        #endregion


        #endregion
    }
}

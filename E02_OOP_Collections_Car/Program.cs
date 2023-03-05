using E02_OOP_Collections_Car.Classes;
using System;
using System.Collections.Generic;
using D00_Utility;


namespace E02_OOP_Collections_Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUniCodeConsole();

            Car cars = new Car();
            try
            {
                #region Create New Car with Asked Values
                #region Data
                List<Car> carList01 = new List<Car>();
                #endregion

                #region Brand Menu
                int brand;
                do
                {
                    Utility.WriteTitle("Chose Brand");
                    brand = cars.AskBrand();
                    switch (brand)
                    {
                        case 1:
                            cars.Brand = Car.EnumBrand.Bólide;
                            break;
                        case 2:
                            cars.Brand = Car.EnumBrand.Mercedes;
                            break;
                        case 3:
                            cars.Brand = Car.EnumBrand.BMW;
                            break;
                        default:
                            Console.WriteLine("Invalid choice, try again");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                } while (brand <= 0 || brand > 3);
                #endregion

                #region Model Menu
                int model;
                do
                {
                    Utility.BlockSeparator(1);
                    Utility.WriteTitle("Chose Model");
                    model = cars.AskModel();
                    switch (model)
                    {
                        case 1:
                            cars.Model = Car.EnumModel.Novo_Bólide;
                            break;
                        case 2:
                            cars.Model = Car.EnumModel.BólideXpto;
                            break;
                        case 3:
                            cars.Model = Car.EnumModel.A220;
                            break;
                        case 4:
                            cars.Model = Car.EnumModel.C220;
                            break;
                        case 5:
                            cars.Model = Car.EnumModel.d118;
                            break;
                        case 6:
                            cars.Model = Car.EnumModel.i420;
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                } while (model <= 0 || model > 6);
                #endregion

                #region Color Menu
                int color;
                do
                {
                    Utility.BlockSeparator(1);
                    Utility.WriteTitle("Chose Color");
                    color = cars.AskColor();
                    switch (color)
                    {
                        case 1:
                            cars.Color = Car.EnumColor.White;
                            break;
                        case 2:
                            cars.Color = Car.EnumColor.Black;
                            break;
                        case 3:
                            cars.Color = Car.EnumColor.Grey;
                            break;
                        case 4:
                            cars.Color = Car.EnumColor.Red;
                            break;
                        case 5:
                            cars.Color = Car.EnumColor.Blue;
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                } while (color <= 0 || color > 5);
                #endregion

                #region Other Properties
                Utility.BlockSeparator(1);                                          // não validado
                Utility.WriteTitle("Write License Plate");                          // não validado
                cars.LicensePlate = cars.AskLicensePlate();                         // não validado
                Utility.BlockSeparator(1);                                          // não validado
                Utility.WriteTitle("Chose Displacement");                           // não validado
                cars.Displacement = cars.AskDisplacement();                         // não validado
                Utility.BlockSeparator(1);                                          // não validado
                Utility.WriteTitle("Chose Registration Date");                      // não validado
                cars.RegistrationDate = cars.AskRegistrationDate();                 // não validado
                #endregion

                #region Create New Car
                cars.CreateNewCar(carList01, cars.Brand, cars.Model, cars.Color, cars.LicensePlate, cars.Displacement, cars.RegistrationDate);
                #endregion

                #region Show New Car
                Console.Clear();
                Utility.WriteTitle("Your Car");
                cars.ShowList(carList01);

                Utility.TerminateConsole();
                #endregion
                #endregion

                #region Stop
                List<Car> carList02 = new List<Car>();
                Car car02 = new Car { Velocity = 100 };
                carList02.Add(car02);

                Utility.WriteTitle("Parar");

                Utility.WriteSubTitle("Velocidade Inicial");
                cars.ShowVelocity(carList02);
                cars.Stop(car02, carList02);

                Utility.WriteSubTitle("Velocidade Final");
                carList02.Clear();
                carList02.Add(car02);
                cars.ShowVelocity(carList02);

                Utility.TerminateConsole();
                #endregion

                #region Acelerate
                List<Car> carList03 = new List<Car>();
                Car car03 = new Car { Velocity = 100 };
                carList03.Add(car03);
                cars.Acelerate(car03, carList03);

                Utility.TerminateConsole();
                #endregion

                #region Decelerate
                List<Car> carList04 = new List<Car>();
                Car car04 = new Car { Velocity = 100 };
                carList04.Add(car04);
                cars.Decelerate(car04, carList04);

                Utility.TerminateConsole();
                #endregion

                #region Acelerate and Decelerate
                List<Car> carList05 = new List<Car>();
                Car car05 = new Car { Velocity = 100 };
                carList05.Add(car05);
                cars.Drive(car05, carList05);
                #endregion
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro."); 
                throw;
            }
           

            Utility.TerminateConsole();

        }
    }
}

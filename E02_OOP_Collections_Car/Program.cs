using E02_OOP_Collections_Car.Classes;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
using System.Collections;

// todo validar restantes menus na classe
// todo loops nos restantes menus no program
namespace E02_OOP_Collections_Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUniCodeConsole();

            Car cars = new Car();

            #region Data
            List<Car> carList= new List<Car>();
            #endregion

            #region Criar carro com valores pedidos
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
            } while (brand<=0 || brand>3);
            #endregion
            #region Model Menu
            Utility.BlockSeparator(1);
            int model = cars.AskModel();
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
            #endregion
            #region Color Menu
            Utility.BlockSeparator(1);
            int color = cars.AskColor();
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
            #endregion

            Utility.TerminateConsole();
            #endregion

        }
    }
}

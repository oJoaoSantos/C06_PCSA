using E01_OOP_Interfaces_Veiculo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Interfaces_Veiculo.Classes
{
    internal class Car: Vehicle, ICar
    {
        #region Enumerations
        public enum EnumColor
        {
            White,
            Black,
            Grey,
            Red
        }
        #endregion

        #region Properties
        public EnumColor Color { get; set; }
        #endregion

        #region Constructor
        public Car(int id, string description, string model, EnumColor color) : base(id, description, model)
        {
            Color = color;
        }
        #endregion

        #region Methods
        public override void Register()
        {
            Console.WriteLine($"ID: {Id}, Description: {Description}, Model: {Model}, Color: {Color}");
        }

        public void Drive()
        {
            Console.WriteLine("Drive: Hearth");
        }
        #endregion

    }
}

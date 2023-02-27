using E01_OOP_Interfaces_Veiculo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Interfaces_Veiculo.Classes
{
    internal class Airplane: Vehicle, IAirplane
    {
        #region Enumerations
        public enum EnumFuel
        {
            Avgas,
            JetB,
            Biokerosene
        }
        #endregion

        #region Properties
        public EnumFuel Fuel { get; set; }
        #endregion

        #region Constructor
        public Airplane(int id, string description, string model, EnumFuel fuel) : base(id, description, model)
        {
            Fuel = fuel;
        }
        #endregion

        #region Methods
        public override void Register()
        {
            Console.WriteLine($"ID: {Id}, Description: {Description}, Model: {Model}, Fuel: {Fuel}");
        }
        public void Fly()
        {
            Console.WriteLine("Fly: Air");
        }
        #endregion

    }
}

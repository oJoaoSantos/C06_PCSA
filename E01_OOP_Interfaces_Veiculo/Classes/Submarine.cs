using E01_OOP_Interfaces_Veiculo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Interfaces_Veiculo.Classes
{
    internal class Submarine: Vehicle, ISubmarine
    {
        #region Properties
        public bool Tripulated { get; set; }
        #endregion

        #region Constructor
        public Submarine(int id, string description, string model, bool tripulated) : base(id, description, model)
        {
            Tripulated = tripulated;
        }
        #endregion

        #region Methods
        public override void Register()
        {
            Console.WriteLine($"ID: {Id}, Description: {Description}, Model: {Model}, Tripulated: {Tripulated}");
        }

        public void Dive()
        {
            Console.WriteLine("Dive: Watter");
        }
        #endregion

    }
}

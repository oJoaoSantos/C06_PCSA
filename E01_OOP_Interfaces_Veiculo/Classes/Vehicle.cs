using E01_OOP_Interfaces_Veiculo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Interfaces_Veiculo.Classes
{
    public class Vehicle: IVehicle
    {
        #region Properties
        public int Id { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        #endregion

        #region Constructors
        public Vehicle() 
        {
            Id = 0;
            Description = string.Empty;
            Model = string.Empty;
        }
        public Vehicle(int id , string description, string model)
        {
            Id = id;
            Description = description;
            Model = model;
        }
        #endregion

        #region Methods
        public virtual void Register()
        {
            Console.WriteLine($"ID: {Id}, Description: {Description}, Model: {Model}");
        }
        public void Terminate()
        { 
            Console.WriteLine("Terminate");
        }
        #endregion
    }
}

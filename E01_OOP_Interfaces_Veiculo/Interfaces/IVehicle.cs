using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Interfaces_Veiculo.Interfaces
{
    internal interface IVehicle
    {
        #region Properties
        //id
        int Id { get; }
        //description
        string Description { get; }
        //model
        string Model { get; }
        #endregion

        #region Methods
        //Register
        void Register();
        //Terminate
        void Terminate();
        //Drive
        #endregion
    }
}

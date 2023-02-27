using E01_OOP_Interfaces_Veiculo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static E01_OOP_Interfaces_Veiculo.Classes.Car;

namespace E01_OOP_Interfaces_Veiculo.Interfaces
{
    internal interface ICar : IVehicle
    {
        #region Properties
        EnumColor Color { get; }
        #endregion

        #region Methods
        void Drive();
        #endregion
    }
}

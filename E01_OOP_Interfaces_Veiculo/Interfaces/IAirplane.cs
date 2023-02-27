using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static E01_OOP_Interfaces_Veiculo.Classes.Airplane;

namespace E01_OOP_Interfaces_Veiculo.Interfaces
{
    internal interface IAirplane: IVehicle
    {
        #region Properties
        EnumFuel Fuel { get; }
        #endregion

        #region Methods
        void Fly();
        #endregion
    }
}

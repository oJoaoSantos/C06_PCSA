using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Interfaces_Veiculo.Interfaces
{
    internal interface ISubmarine: IVehicle
    {
        #region Properties
        bool Tripulated { get; }
        #endregion
        #region Methods
        void Dive();
        #endregion
    }
}

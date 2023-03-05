using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_OOP_Calculator_v01.Interfaces
{
    internal interface IScientificCalculator : ICalculator
    {
        #region Methods
        void SquareRoot(double value1);
        #endregion
    }
}

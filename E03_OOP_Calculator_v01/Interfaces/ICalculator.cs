using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_OOP_Calculator_v01.Interfaces
{
    internal interface ICalculator
    {
        #region Properties
        double Value01 { get; }
        double Value02 { get; }
        double Value03 { get; }
        #endregion

        #region Methods
        double AskNumber(int number);
        void Sum(double value1, double value2, double value3);
        void Subtract(double value1, double value2, double value3);
        void Multiply(double value1, double value2, double value3);
        void Divide(double value1, double value2, double value3);
        #endregion
    }
}

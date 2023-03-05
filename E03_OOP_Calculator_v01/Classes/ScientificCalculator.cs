using D00_Utility;
using E03_OOP_Calculator_v01.Interfaces;
using System;

namespace E03_OOP_Calculator_v01
{
    internal class ScientificCalculator : Calculator, IScientificCalculator
    {
        #region Methods
        public void SquareRoot(double value1)
        {
            Console.Clear();
                Utility.WriteTitle("SquareRoot");
                Console.WriteLine($"The quareRoot of {value1} is {Math.Sqrt(value1)}");
        }
        #endregion
    }
}

using System;
using D00_Utility;
using E03_OOP_Calculator_v01.Interfaces;

namespace E03_OOP_Calculator_v01
{
    internal class Calculator : ICalculator
    {
        #region Properties
        public double Value01 { get; set; }
        public double Value02 { get; set; }
        public double Value03 { get; set; }
        #endregion

        #region Constructor
        public Calculator()
        { 
            Value01= 0;
            Value02 = 0;
            Value03 = 0;
        }
        #endregion

        #region Methods
        public double AskNumber(int number)
        {
            string readed;
            bool converted;
            do
            {
                Console.Write($"Number {number}: ");
                readed = Console.ReadLine();
                converted = Utility.ValidateStringDouble(readed);
                if (converted == false)
                {
                    Console.WriteLine("Invalid Number");
                }
            } while (converted == false);
            return double.Parse(readed);
        }
        public void Sum(double value1, double value2, double value3)
        {
            Console.Clear();
            if (value3 == 0)
            {
                Utility.WriteTitle("Sum of 2 Numbers");
                Console.WriteLine($"{value1} + {value2} = {value1 + value2}");
            }
            else
            {
                Utility.WriteTitle("Sum of 3 Numbers");
                Console.WriteLine($"{value1} + {value2} + {value3} = {value1 + value2 + value3}");
            }
            
        }

        public void Subtract(double value1, double value2, double value3)
        {
            Console.Clear();
            if (value3 == 0)
            {
                Utility.WriteTitle("Subtraction of 2 Numbers");
                Console.WriteLine($"{value1} - {value2} = {value1 - value2}");
            }
            else
            {
                Utility.WriteTitle("Subtraction of 3 Numbers");
                Console.WriteLine($"{value1} - {value2} - {value3} = {value1 - value2 - value3}");
            }
        }

        public void Multiply(double value1, double value2, double value3)
        {
            Console.Clear();
            if (value3 == 0)
            {
                Utility.WriteTitle("Multiplication of 2 Numbers");
                Console.WriteLine($"{value1} X {value2} = {value1 * value2}");
            }
            else
            {
                Utility.WriteTitle("Multiplication of 3 Numbers");
                Console.WriteLine($"{value1} X {value2} X {value3} = {value1 * value2 * value3}");
            }
        }

        public void Divide(double value1, double value2, double value3)
        {
            Console.Clear();
            if (value3 == 0)
            {
                Utility.WriteTitle("Division of 2 Numbers");
                Console.WriteLine($"{value1} / {value2} = {value1 / value2}");
            }
            else
            {
                Utility.WriteTitle("Division of 3 Numbers");
                Console.WriteLine($"{value1} / {value2} / {value3} = {value1 / value2 / value3}");
            }
        }
        #endregion
    }
}

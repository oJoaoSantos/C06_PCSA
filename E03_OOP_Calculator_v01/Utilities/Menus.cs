using D00_Utility;
using System;
using System.Collections.Generic;

namespace E03_OOP_Calculator_v01
{
    public static class Menus
    {
        #region Calculatror
        public static Dictionary<int, string> Calculators()
        {
            Dictionary<int, string> listCalculators = new Dictionary<int, string>()
            {
                { 1, "Simple"},
                { 2, "Scientific"},
                { 0, "End Program" }
            };

            foreach (KeyValuePair<int, string> item in listCalculators)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            return listCalculators;
        }
        public static int AskCalculator()
        {
            Dictionary<int, string> listOperations = Calculators();
            string readed;
            bool converted, valid = false;
            do
            {
                Console.Write("Calculator: ");
                readed = Console.ReadLine();
                converted = Utility.ValidateStringDouble(readed);
                if (converted == false)
                {
                    Console.WriteLine("Invalid Choice");
                }
                else
                {
                    valid = listOperations.ContainsKey(int.Parse(readed));
                    if (valid == false)
                    {
                        Console.WriteLine("Invalid Choice");
                    }
                }
            } while (converted == false || valid == false);
            return int.Parse(readed);
        }
        #endregion

        #region Operation

        #region Operation Simple Calculator
        public static Dictionary<int, string> Operation1()
        {
            Dictionary<int, string> listOperations = new Dictionary<int, string>()
            {
                { 1, "Sum"},
                { 2, "Subtract"},
                { 3, "Multiply"},
                { 4, "Divide"}
            };

            foreach (KeyValuePair<int, string> item in listOperations)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            return listOperations;
        }
        public static int AskOperation1()
        {
            Dictionary<int, string> listOperations = Operation1();
            string readed;
            bool converted, valid = false;
            do
            {
                Console.Write("Operation: ");
                readed = Console.ReadLine();
                converted = Utility.ValidateStringDouble(readed);
                if (converted == false)
                {
                    Console.WriteLine("Invalid Choice");
                }
                else
                {
                    valid = listOperations.ContainsKey(int.Parse(readed));
                    if (valid == false)
                    {
                        Console.WriteLine("Invalid Choice");
                    }
                }
            } while (converted == false || valid == false);
            return int.Parse(readed);
        }
        #endregion

        #region Operation Scientific Calculator
        public static Dictionary<int, string> Operation2()
        {
            Dictionary<int, string> listOperations = new Dictionary<int, string>()
            {
                { 1, "Sum"},
                { 2, "Subtract"},
                { 3, "Multiply"},
                { 4, "Divide"},
                { 5, "Square Root"}

            };

            foreach (KeyValuePair<int, string> item in listOperations)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            return listOperations;
        }
        public static int AskOperation2()
        {
            Dictionary<int, string> listOperations = Operation2();
            string readed;
            bool converted, valid = false;
            do
            {
                Console.Write("Operation: ");
                readed = Console.ReadLine();
                converted = Utility.ValidateStringDouble(readed);
                if (converted == false)
                {
                    Console.WriteLine("Invalid Choice");
                }
                else
                {
                    valid = listOperations.ContainsKey(int.Parse(readed));
                    if (valid == false)
                    {
                        Console.WriteLine("Invalid Choice");
                    }
                }
            } while (converted == false || valid == false);
            return int.Parse(readed);
        }
        #endregion

        #endregion

        #region Number of Values
        public static Dictionary<int, string> Values()
        {
            Dictionary<int, string> numberOfValues = new Dictionary<int, string>()
            {
                { 2, " Numbers"},
                { 3, " Numbers"}
            };

            foreach (KeyValuePair<int, string> item in numberOfValues)
            {
                Console.WriteLine($"{item.Key}{item.Value}");
            }
            return numberOfValues;
        }
        public static int AskNumberValues()
        {
            Dictionary<int, string> listOperations = Values();
            string readed;
            bool converted, valid = false;
            do
            {
                Console.Write("2 or 3: ");
                readed = Console.ReadLine();
                converted = Utility.ValidateStringDouble(readed);
                if (converted == false)
                {
                    Console.WriteLine("Invalid Choice");
                }
                else
                {
                    valid = listOperations.ContainsKey(int.Parse(readed));
                    if (valid == false)
                    {
                        Console.WriteLine("Invalid Choice");
                    }
                }
            } while (converted == false || valid == false);
            return int.Parse(readed);
        }
        #endregion

    }
}

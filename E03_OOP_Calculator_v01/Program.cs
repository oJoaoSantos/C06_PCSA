using System;
using D00_Utility;

namespace E03_OOP_Calculator_v01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUniCodeConsole();

            try
            {
                int calculator = 1;

                while (calculator != 0)
                {
                    #region Choose Calculator
                    Console.Clear();
                    Utility.WriteTitle("Choose Calculator");
                    calculator = Menus.AskCalculator();
                    #endregion

                    if (calculator == 0)
                    {
                        #region End Program
                        Utility.TerminateConsole();
                        #endregion
                    }
                    else if (calculator == 1)
                    {
                        #region Simple Calculator
                        Calculator calculatorSimple = new Calculator();

                        #region Ask Operation
                        Console.Clear();
                        Utility.WriteTitle("Choose Operation");
                        int operation = Menus.AskOperation1();
                        #endregion

                        #region Ask Quantity of Values
                        Console.Clear();
                        Utility.WriteTitle("Number of Values ​​to Use");
                        int valuesQuant = Menus.AskNumberValues();
                        #endregion

                        if (valuesQuant == 2)
                        {
                            #region Ask 2 Values

                            bool validated;
                            Console.Clear();
                            Utility.WriteTitle("Numbers to Calculate");
                            calculatorSimple.Value01 = calculatorSimple.AskNumber(1);
                            //Divide Validation
                            if (operation == 4)
                            {
                                do
                                {
                                    calculatorSimple.Value02 = calculatorSimple.AskNumber(2);
                                    validated = Utility.ValidateNumber(calculatorSimple.Value02);
                                    if (validated == false)
                                    {
                                        Console.WriteLine("Impossible to divide per 0.");
                                    }
                                } while (validated == false);
                            }
                            else
                            {
                                calculatorSimple.Value02 = calculatorSimple.AskNumber(2);
                            }
                            #endregion
                        }
                        else
                        {
                            #region Ask 3 Values
                            bool validated;
                            Console.Clear();
                            Utility.WriteTitle("Numbers to Calculate");
                            calculatorSimple.Value01 = calculatorSimple.AskNumber(1);
                            //Divide Validation
                            if (operation == 4)
                            {
                                do
                                {
                                    calculatorSimple.Value02 = calculatorSimple.AskNumber(2);
                                    validated = Utility.ValidateNumber(calculatorSimple.Value02);
                                    if (validated == false)
                                    {
                                        Console.WriteLine("Impossible to divide per 0.");
                                    }
                                } while (validated == false);
                                do
                                {
                                    calculatorSimple.Value03 = calculatorSimple.AskNumber(3);
                                    validated = Utility.ValidateNumber(calculatorSimple.Value03);
                                    if (validated == false)
                                    {
                                        Console.WriteLine("Impossible to divide per 0.");
                                    }
                                } while (validated == false);
                            }
                            else
                            {
                                calculatorSimple.Value02 = calculatorSimple.AskNumber(2);
                                calculatorSimple.Value03 = calculatorSimple.AskNumber(3);
                            }

                            #endregion
                        }

                        #region Calculate
                        switch (operation)
                        {
                            case 1:
                                calculatorSimple.Sum(calculatorSimple.Value01, calculatorSimple.Value02, calculatorSimple.Value03);
                                Utility.TerminateConsole();
                                break;
                            case 2:
                                calculatorSimple.Subtract(calculatorSimple.Value01, calculatorSimple.Value02, calculatorSimple.Value03);
                                Utility.TerminateConsole();
                                break;
                            case 3:
                                calculatorSimple.Multiply(calculatorSimple.Value01, calculatorSimple.Value02, calculatorSimple.Value03);
                                Utility.TerminateConsole();
                                break;
                            default:
                                calculatorSimple.Divide(calculatorSimple.Value01, calculatorSimple.Value02, calculatorSimple.Value03);
                                Utility.TerminateConsole();
                                break;
                        }
                        #endregion

                        #endregion
                    }
                    else
                    {
                        #region Scientific Calculator
                        ScientificCalculator scientificCalculator = new ScientificCalculator();

                        #region Ask Operation
                        Console.Clear();
                        Utility.WriteTitle("Escolhe a Operação");
                        int operation = Menus.AskOperation2();
                        #endregion

                        if (operation == 5)
                        {
                            #region Ask Value
                            Console.Clear();
                            Utility.WriteTitle("Number to Calculate SQR");
                            scientificCalculator.Value01 = scientificCalculator.AskNumber(1);
                            #endregion

                            #region Calculate
                            scientificCalculator.SquareRoot(scientificCalculator.Value01);
                            Utility.TerminateConsole();
                            #endregion
                        }
                        else
                        {
                            #region Ask Quantity of Values
                            Console.Clear();
                            Utility.WriteTitle("Number of Values ​​to Use");
                            int valuesQuant = Menus.AskNumberValues();
                            #endregion

                            if (valuesQuant == 2)
                            {
                                #region Ask 2 Values

                                bool validated;
                                Console.Clear();
                                Utility.WriteTitle("Numbers to Calculate");
                                scientificCalculator.Value01 = scientificCalculator.AskNumber(1);
                                //Divide Validation
                                if (operation == 4)
                                {
                                    do
                                    {
                                        scientificCalculator.Value02 = scientificCalculator.AskNumber(2);
                                        validated = Utility.ValidateNumber(scientificCalculator.Value02);
                                        if (validated == false)
                                        {
                                            Console.WriteLine("Impossible to divide per 0.");
                                        }
                                    } while (validated == false);
                                }
                                else
                                {
                                    scientificCalculator.Value02 = scientificCalculator.AskNumber(2);
                                }
                                #endregion
                            }
                            else
                            {
                                #region Ask 3 Values
                                bool validated;
                                Console.Clear();
                                Utility.WriteTitle("Numbers to Calculate");
                                scientificCalculator.Value01 = scientificCalculator.AskNumber(1);
                                //Divide Validation
                                if (operation == 4)
                                {
                                    do
                                    {
                                        scientificCalculator.Value02 = scientificCalculator.AskNumber(2);
                                        validated = Utility.ValidateNumber(scientificCalculator.Value02);
                                        if (validated == false)
                                        {
                                            Console.WriteLine("Impossible to divide per 0.");
                                        }
                                    } while (validated == false);
                                    do
                                    {
                                        scientificCalculator.Value03 = scientificCalculator.AskNumber(3);
                                        validated = Utility.ValidateNumber(scientificCalculator.Value03);
                                        if (validated == false)
                                        {
                                            Console.WriteLine("Impossible to divide per 0.");
                                        }
                                    } while (validated == false);
                                }
                                else
                                {
                                    scientificCalculator.Value02 = scientificCalculator.AskNumber(2);
                                    scientificCalculator.Value03 = scientificCalculator.AskNumber(3);
                                }

                                #endregion
                            }

                            #region Calculate
                            switch (operation)
                            {
                                case 1:
                                    scientificCalculator.Sum(scientificCalculator.Value01, scientificCalculator.Value02, scientificCalculator.Value03);
                                    Utility.TerminateConsole();
                                    break;
                                case 2:
                                    scientificCalculator.Subtract(scientificCalculator.Value01, scientificCalculator.Value02, scientificCalculator.Value03);
                                    Utility.TerminateConsole();
                                    break;
                                case 3:
                                    scientificCalculator.Multiply(scientificCalculator.Value01, scientificCalculator.Value02, scientificCalculator.Value03);
                                    Utility.TerminateConsole();
                                    break;
                                default:
                                    scientificCalculator.Divide(scientificCalculator.Value01, scientificCalculator.Value02, scientificCalculator.Value03);
                                    Utility.TerminateConsole();
                                    break;
                            }
                            #endregion
                        }
                        #endregion
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro.");
                throw;
            }
        }
    }
}

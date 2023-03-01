// Stack --> Pilha -> LIFO (last in, first out)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D09_CollectionsGeneric_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUniCodeConsole();

            #region Stack -> Int (Pilha)
            Stack<int> stackIntegers = new Stack<int>();
            for (int i = 0; i < 6; i++)
            {
                stackIntegers.Push(i);
            }
            stackIntegers.Push(10);
            stackIntegers.Push(20);

            Utility.WriteTitle("Stack - Push");
            foreach (int item in stackIntegers)
            {
                Console.WriteLine(item);
            }

            int countStackIntegers = stackIntegers.Count();
            Console.WriteLine($"\n\nCount: {countStackIntegers}\n\n");

            Utility.WriteTitle("Stack - Pop");
            for (int i = 0; i < countStackIntegers; i++)
            {
                Console.WriteLine(stackIntegers.Pop());
            }

            countStackIntegers = stackIntegers.Count();
            Console.WriteLine($"\n\nCount: {countStackIntegers}");
            #endregion

            Utility.TerminateConsole();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D11_CollectionsGeneric_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUniCodeConsole();

            #region IList<T>
            EvenNumber evenListNumbers01 = new EvenNumber();

            IList<int> listNumbers01 = evenListNumbers01.CreateEvenNumbersList(10);

            Utility.WriteTitle("IList<T>");
            foreach (int item in listNumbers01)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region IEnumerable<T>
            EvenNumber evenListNumbers02 = new EvenNumber();

            IEnumerable<int> listNumbers02 = evenListNumbers01.CreateEvenNumbersList(10);

            Utility.BlockSeparator(2);
            Utility.WriteTitle("IEnumerable<T>");
            foreach (int item in listNumbers02)
            {
                Console.WriteLine(item);
            }
            #endregion

            Utility.TerminateConsole();
        }
    }
}

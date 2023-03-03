using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace D11_CollectionsGeneric_IEnumerable
{
    internal class EvenNumber
    {
        #region Method IList<T> type

        public IList<int> CreateEvenNumbersList(int quantity)
        {
            List<int> evenNumbersList = new List<int>(quantity);
            int currentNumber = 0;

            while (evenNumbersList.Count <= quantity)
            {
                if (++currentNumber % 2 == 0)
                { 
                evenNumbersList.Add(currentNumber);      
                }
            }
            return evenNumbersList;                     // devolve a lista
        }

        #endregion

        #region Method IEnumerable<T> type

        public IEnumerable<int> CreateNumbersInumerable(int quantity)
        {
            int currentNumber = 0;
            while (++currentNumber <= quantity)
            {
                if (currentNumber % 2 == 0)
                {
                    yield return currentNumber;         // devolve o próximo valor da iteração
                }
            }
        }

        #endregion
    }
}

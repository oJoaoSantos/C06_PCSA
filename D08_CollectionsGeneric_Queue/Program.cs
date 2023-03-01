// Queue --> Fila -> FIFO (first in, first out)

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D08_CollectionsGeneric_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUniCodeConsole();

            #region Queue -> Int (fila)
            Queue<int> queueIntegers = new Queue<int>();            
            for (int i = 0; i < 6; i++)
            {
                queueIntegers.Enqueue(i);

            }
            queueIntegers.Enqueue(10);
            queueIntegers.Enqueue(20);

            Utility.WriteTitle("Queue - Enqueue");
            foreach (int item in queueIntegers)
            {
                Console.WriteLine(item);
            }

            int countQueueIntegers = queueIntegers.Count();
            Console.WriteLine($"\n\nCount: {countQueueIntegers}\n\n");

            Utility.WriteTitle("Queue - Dequeue");
            for (int i = 0; i < countQueueIntegers; i++)
            {
                Console.WriteLine(queueIntegers.Dequeue());
            }

            countQueueIntegers = queueIntegers.Count();
            Console.WriteLine($"\n\nCount: {countQueueIntegers}");
            #endregion

            Utility.TerminateConsole();
        }
    }
}

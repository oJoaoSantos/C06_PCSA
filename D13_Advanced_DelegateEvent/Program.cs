using System;

namespace D13_Advanced_DelegateEvent
{

    class Program
    {

        static void Main(string[] args)
        {
           
            #region 1. Delegates

            #region Métodos sem delegate - GreetingClass
            
            Console.WriteLine("Métodos sem delegate\n");
            
            GreetingClass.WriteGreetingClassic("PT", "Milena");
            GreetingClass.WriteGreetingClassic("EN", "Milena");
            
            Console.ReadKey();
            
            #endregion

            #region Métodos com delegate clássico - GreetingClass
            
            Console.WriteLine("\n\n\nMétodos com delegate clássico\n");

            GreetingClass.WriteGreetingDelegate(GreetingClass.PortugueseGreeting, "Milena");
            GreetingClass.WriteGreetingDelegate(GreetingClass.EnglishGreeting, "Milena");

            Console.ReadKey();
            
            #endregion

            #region Métodos Function<T, TResult> - CalculateClass
            
            Console.WriteLine("\n\n\nMétodos com delegate Function<T, TResult>\n");
            
            Func<int, int, int> CalculateAdd = CalculateClass.Add;
            Func<int, int, int> CalculateSubtract = CalculateClass.Subtract;
            
            Console.WriteLine(CalculateAdd(10, 20));

            Console.WriteLine(CalculateSubtract(20, 10));

            Console.ReadKey();
            Console.Clear();
            
            #endregion

            #endregion


            #region 2.Events
            
            ClassEventTest myLesson = new ClassEventTest();

            myLesson.TestEvent();

            Console.ReadKey();
            
            #endregion

        }

    }

}

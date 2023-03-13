using System;

namespace D13_Advanced_DelegateEvent
{

    public static class GreetingClass
    {
        
        public delegate void Greeting(string name);

        public static void PortugueseGreeting(string name)
        {
            Console.WriteLine($"Olá {name}");
        }

        public static void EnglishGreeting(string name)
        {
            Console.WriteLine($"Hi {name}");
        }
        
        public static void WriteGreetingClassic(string language, string name)
        {
            if (language == "PT")
                PortugueseGreeting(name);
            else if (language == "EN")
                EnglishGreeting(name);
        }

        public static void WriteGreetingDelegate(Greeting greeting, string name)
        {
            greeting(name);
        }        

    }

}

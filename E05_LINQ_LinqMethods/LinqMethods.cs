using System;
using System.Collections.Generic;
​
namespace E05_LINQ_LinqMethods
{​
        public class LinqMethods
        {

            public static void Methods()
            {
​
                // Lista genérica de timespans
                List<TimeSpan> timeSpanList = new List<TimeSpan>();
​
                // Variável aleatória
                Random random = new Random();
​
                // Timespan entre 0 e 24
                TimeSpan start = TimeSpan.FromHours(0);
                TimeSpan end = TimeSpan.FromHours(24);
​
                // Calcular os minutos para servir de cálculo às horas
                int maxMinutes = (int)(end - start).TotalMinutes;       // (int) operação de cast
​
                // Preencher o random
                for (int i = 0; i < 10; ++i)
                {
                    int minutes = random.Next(maxMinutes);
                    timeSpanList.Add(start.Add(TimeSpan.FromMinutes(minutes)));
                }
​
                /*
                    1. Criar uma lista de 10 timespans aleatórios entre 0 e 24 horas
                    2. Usar FindAll() para localizar todas as timespans inferiores a 12 horas
                    3. Usar Exists() para verificar se alguma timespan tiver 5 na propriedade Hours
                    4. Usar TrueForAll() para garantir que todas as timespans estão entre 0 e 24 horas
                    5. Usar ConvertAll() para retornar só a parte de Hours de cada timespan
                */
​
                // FindAll
                var ex1 = timeSpanList.FindAll(s => s < new TimeSpan(12, 0, 0));
​
                // Exists
                var ex2 = timeSpanList.Exists(s => s.Hours == 5);
​
                // TrueForAll
                var ex3 = timeSpanList.TrueForAll(s => s >= new TimeSpan(0, 0, 0) && s <= new TimeSpan(23, 59, 59));
​
                // ConvertAll
                var ex4 = timeSpanList.ConvertAll(s => s.Hours);
​
​
                // Listar
                Console.WriteLine($"{new string('-', 50)}\nLINQ - LINQ Methods\n{new string('-', 50)}\n");

                Console.WriteLine("\n\n1. Lista de timespans\n");
                foreach (var item in timeSpanList)
                {
                    Console.WriteLine(item);
                }
​
                Console.WriteLine("\n\n2. FindAll\n");
                foreach (TimeSpan t in ex1)
                {
                    Console.WriteLine(t);
                }
​
                Console.WriteLine("\n\n3. Exists\n");
                Console.WriteLine(ex2);
​
                Console.WriteLine("\n\n4. TrueForAll\n");
                Console.WriteLine(ex3);
​
                Console.WriteLine("\n\n5. ConvertAll\n");
                foreach (int h in ex4)
                {
                    Console.WriteLine(h);
                }
​
            }
​
        }
​
}

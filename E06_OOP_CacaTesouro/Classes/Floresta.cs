using E06_OOP_CacaTesouro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E06_OOP_CacaTesouro.Classes
{
    public class Floresta : IFloresta
    {
        #region Properties
        public int Comprimento { get; set; }
        public int Altura { get; set; }
        public int XTesouro { get; set; }
        public int YTesouro { get; set; }
        #endregion

        #region Constructors

        #endregion

        #region Methods
        public string[,] CriarFloresta()
        {
            string[,] floresta = new string[,]
            {
                { "___", "___", "___", "___", "___", "___", "___", "___", "___", "___" },
                { "___", "___", "___", "___", "___", "___", "___", "___", "___", "___" },
                { "___", "___", "___", "___", "___", "___", "___", "___", "___", "___" },
                { "___", "___", "___", "___", "___", "___", "___", "___", "___", "___" },
                { "___", "___", "___", "___", "___", "___", "___", "___", "___", "___" },
                { "___", "___", "___", "___", "___", "___", "___", "___", "___", "___" },
                { "___", "___", "___", "___", "___", "___", "___", "___", "___", "___" },
                { "___", "___", "___", "___", "___", "___", "___", "___", "___", "___" },
                { "___", "___", "___", "___", "___", "___", "___", "___", "___", "___" },
                { "___", "___", "___", "___", "___", "___", "___", "___", "___", "___" },
            };
            return floresta;
        }

        public void MostrarFloresta(string[,] floresta)
        {
            Utility.WriteTitle("Floresta");
            for (int i = 0; i < 10; i++)
            {
                for (int c = 0; c < 10; c++)
                {
                    Console.Write($"{floresta[i, c]}\t");
                }
                Console.WriteLine("\n\n");
            }
        }

        //public string[,] PosicionarObstaculos(string[,] floresta)
        //{
        //    Random random = new Random();
        //    for (int i = 0; i < 20; i++)
        //    {
        //        floresta[random.Next(0, 10), random.Next(0, 10)] = "_-_";
        //    }            
        //    return floresta;
        //}

        public void EncontarX()
        {
            Random random = new Random();
            int x = random.Next(0, 9);
            XTesouro = x;
        }
        public void EncontarY()
        {
            Random random = new Random();
            int y = random.Next(0, 9);
            YTesouro = y;
        }
        public string[,] PosicionarTesouro(string[,] floresta, int x, int y)
        {
            Random random = new Random();

            floresta[y, x] = "_T_";
            return floresta;
        }
        #endregion
    }
}

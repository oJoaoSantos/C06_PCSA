using E06_OOP_CacaTesouro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E06_OOP_CacaTesouro.Classes
{
    public class Veiculo : IVeiculo
    {
        #region Properties
        public string Nome { get; set; }
        public int Direcao { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Methods
        public void EncontarX()
        {
            Random random = new Random();
            int x = random.Next(0, 9);
            X = x;
        }
        public void EncontarY()
        {
            Random random = new Random();
            int y = random.Next(0, 9);
            Y = y;
        }
        public virtual string[,] PosicionarVeiculo(string[,] floresta, int x, int y)
        {
            floresta[y,x] = "_V_";
            return floresta;
        }
        public void SelecionarDirecao()
        {
            Random random = new Random();
            Direcao = random.Next(1,4);
            // 1 = direta, 2 = baixo, 3 esquerda, 4 cima.
        }

        public virtual string[,] Deslocar(string[,] floresta, int direcao, int x, int y)
        {
            switch (direcao)
            {
                case 1:
                    if (x == 9)
                    {
                        floresta[y, x] = "_V_";
                    }
                    else
                    {
                        floresta[y, x] = "___";
                        floresta[y, x++] = "_V_";
                        X = X++;
                    }
                    break;
                case 2:
                    if (y == 9)
                    {
                        floresta[y, x] = "_V_";
                    }
                    else
                    {
                        floresta[y, x] = "___";
                        floresta[y++, x] = "_V_";
                        Y = Y++;
                    }
                    break;
                case 3:
                    if (x == 0)
                    {
                        floresta[y, x] = "_V_";
                    }
                    else
                    {
                        floresta[y, x] = "___";
                        floresta[y, x--] = "_V_";
                        X = X--;
                    }
                    break;
                case 4:
                    if (y == 0)
                    {
                        floresta[y, x] = "_V_";
                    }
                    else
                    {
                        floresta[y, x] = "___";
                        floresta[y--, x] = "_V_";
                        Y = Y--;
                    }
                    break;
                default: { Console.WriteLine("erro"); }; break;
            }
            return floresta;
        }
        #endregion

    }
}

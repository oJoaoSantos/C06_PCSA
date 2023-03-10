using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E06_OOP_CacaTesouro.Interfaces
{
    internal interface IFloresta
    {
        #region Properties
        int Comprimento { get; }
        int Altura { get; }
        int XTesouro { get; }
        int YTesouro { get; }
        #endregion

        #region Methods
        string[,] CriarFloresta();
        void MostrarFloresta(string[,] floresta);
        //string[,] PosicionarObstaculos(string[,] floresta);
        void EncontarX();
        void EncontarY();
        string[,] PosicionarTesouro(string[,] floresta, int x, int y);
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E06_OOP_CacaTesouro.Interfaces
{
    internal interface IVeiculo
    {
        #region Properties
        string Nome { get; }
        int Direcao { get; }
        #endregion

        #region Methods
        void EncontarX();
        void EncontarY();
        string[,] PosicionarVeiculo(string[,] floresta, int x, int y);
        void SelecionarDirecao();
        string[,] Deslocar(string[,] floresta, int direcao, int x, int y);
        #endregion
    }
}

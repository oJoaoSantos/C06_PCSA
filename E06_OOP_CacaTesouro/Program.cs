using E06_OOP_CacaTesouro.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E06_OOP_CacaTesouro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUniCodeConsole();

            #region Floresta
            Floresta floresta = new Floresta();
            string[,] florestaCriada = floresta.CriarFloresta();
            //florestaCriada = floresta.PosicionarObstaculos(florestaCriada);
            floresta.EncontarX();
            floresta.EncontarY();
            florestaCriada = floresta.PosicionarTesouro(florestaCriada, floresta.XTesouro, floresta.YTesouro);
            floresta.MostrarFloresta(florestaCriada);
            #endregion

            #region Veiculo Teste
            Veiculo veiculo = new Veiculo();
            veiculo.EncontarX();
            Console.WriteLine(veiculo.X);
            veiculo.EncontarY();
            Console.WriteLine(veiculo.Y);
            florestaCriada = veiculo.PosicionarVeiculo(florestaCriada, veiculo.X, veiculo.Y);
            floresta.MostrarFloresta(florestaCriada);
            while (veiculo.X != floresta.XTesouro && veiculo.Y != floresta.YTesouro)
            {
                veiculo.SelecionarDirecao();
                Console.WriteLine(veiculo.Direcao);
                Console.WriteLine($"Coordenadas: x={veiculo.X}, y={veiculo.Y}");
                veiculo.Deslocar(florestaCriada, veiculo.Direcao, veiculo.X, veiculo.Y);
                floresta.MostrarFloresta(florestaCriada);
            };
           
            floresta.MostrarFloresta(florestaCriada);
            Console.WriteLine(veiculo.X);
            Console.WriteLine(veiculo.Y);
            Console.WriteLine("Veículo Encontrou");
            #endregion

            Utility.TerminateConsole();
        }
    }
}

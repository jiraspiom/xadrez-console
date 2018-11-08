using System;
using tabuleiro;

namespace xadrezdos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);

        }
    }
}

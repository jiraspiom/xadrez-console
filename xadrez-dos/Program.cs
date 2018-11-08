using System;
using xadrezdos.Tabuleiro;

namespace xadrezdos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Posicao p;
            p = new Posicao(2, 4);
            Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}

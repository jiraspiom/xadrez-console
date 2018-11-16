using System;
using System.Globalization;

namespace cSharp2018
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digita a data");

            string nome = Console.ReadLine();

            nome = nome.Insert(4, "-");
            nome = nome.Insert(7, "-");

            Console.WriteLine(nome);
        }
    }
}

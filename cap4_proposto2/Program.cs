using System;
using System.Collections.Generic;
using cap4_proposto2.Dominio;

namespace cap4_proposto2
{
    class MainClass
    {
        public static List<Marca> listaMarcas = new List<Marca>();

        public static List<Carro> listaCarros = new List<Carro>();

        public static void Main(string[] args)
        {

            Marca marca1 = new Marca(1001, "Volkwagem", "Alemanha");
            Marca marca2 = new Marca(1002, "General Motors", "Estados Unidos");

            Carro carro1 = new Carro(101, "Fusca", 1980, 5000.00, marca1);
            marca1.addCarro(carro1);
            Carro carro2 = new Carro(102, "Golf", 2006, 60000.00, marca1);
            marca1.addCarro(carro2);
            Carro carro3 = new Carro(103, "Fox", 2017, 30000.00, marca1);
            marca1.addCarro(carro3);

            Carro carro4 = new Carro(104, "Cruze", 2016, 30000.00, marca2);
            marca2.addCarro(carro4);
            Carro carro5 = new Carro(105, "Cobalt", 2015, 25000.00, marca2);
            marca2.addCarro(carro5);
            Carro carro6 = new Carro(106, "Cobalt", 2017, 35000.00, marca2);
            marca2.addCarro(carro6);

            listaMarcas.Add(marca1);
            listaMarcas.Add(marca2);

            Console.Clear();
            int opcaoSelecao = 0;

            while(opcaoSelecao != 7){

                Console.Clear();
                Tela.mostrarMenu();

                Console.Write("Seleciona uma opção: ");

                opcaoSelecao = int.Parse(Console.ReadLine());

                if (opcaoSelecao == 1){
                    Tela.listarMarcas();
                
                }else if(opcaoSelecao == 2){
                    Tela.listarCarroMarcaOrdenadamente();
               
                }else if(opcaoSelecao == 3){
                    Tela.cadastrarMarca();
                
                }else if(opcaoSelecao == 4){
                    Tela.cadastrarCarro();
                
                }else if(opcaoSelecao == 5){
                    Tela.cadastrarAcessorio();
                }else if(opcaoSelecao == 6){
                    Tela.MostrarDetalheCarro();
                }else{
                    Console.WriteLine("opção não reconhecido!");
                }

                Console.ReadLine();

            }

        }
    }
}

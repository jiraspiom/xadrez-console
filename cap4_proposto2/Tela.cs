using System;
using System.Collections.Generic;
using System.Globalization;
using cap4_proposto2.Dominio;

namespace cap4_proposto2
{
    public static class Tela
    {
        public static void mostrarMenu()
        {

            Console.WriteLine("1 – Listar marcas                                |");
            Console.WriteLine("2 – Listar carros de uma marca ordenadamente*    |");
            Console.WriteLine("3 – Cadastrar marca                              |");
            Console.WriteLine("4 – Cadastrar carro                              |");
            Console.WriteLine("5 – Cadastrar acessório                          |");
            Console.WriteLine("6 – Mostrar detalhes de um carro                 |");
            Console.WriteLine("7 – Sair                                         |");
            Console.WriteLine("_________________________________________________");

        }

        public static void listarMarcas()
        {
            Console.WriteLine("LISTAGEM DE MARCAS:");
            for (int i = 0; i < MainClass.listaMarcas.Count; i++)
            {
                Console.WriteLine(MainClass.listaMarcas[i]);
            }

        }

        public static void listarCarroMarcaOrdenadamente()
        {
            Console.Write("Digite o código da marca: ");

            int codMarca = int.Parse(Console.ReadLine());

            int posisao = MainClass.listaMarcas.FindIndex(x => x.codigo == codMarca);

            if (posisao != -1)
            {
                Console.WriteLine("Carros da marca " + MainClass.listaMarcas[posisao].nome);

                List<Carro> lista = MainClass.listaMarcas[posisao].carros;

                //for (int i = 0; i < MainClass.listaMarcas[posisao].carros.Count; i++){
                for (int i = 0; i < lista.Count; i++)
                {
                    //Console.WriteLine(MainClass.listaMarcas[posisao].carros[i]);
                    Console.WriteLine(lista[i]);
                }

            }

        }

        public static void cadastrarMarca()
        {
            Console.WriteLine("Digite os dados da marca:");
            Console.Write("Codigo: "); 
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("País de origem: ");
            string pais = Console.ReadLine();

            MainClass.listaMarcas.Add(new Marca(codigo, nome, pais));

        }

        public static void cadastrarCarro()
        {
            Console.WriteLine("Digite os dados do carro: ");
            Console.Write("Marca (código): ");
            int codMarca = int.Parse(Console.ReadLine());

            int posissaoMarca = MainClass.listaMarcas.FindIndex(x => x.codigo == codMarca);

            if (posissaoMarca == -1){
                throw new ModeloExcessao("Código de marca não encontrado: " + codMarca);
            }

            Console.Write("Código do carro: ");
            int codCarro = int.Parse(Console.ReadLine());

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Preço básico: ");
            double precoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Marca m = MainClass.listaMarcas[posissaoMarca];
            Carro c = new Carro(codCarro, modelo, ano, precoB, m);

            m.addCarro(c);
            MainClass.listaCarros.Add(c);

        }

        public static void cadastrarAcessorio()
        {
            Console.WriteLine("Digite os dados do acessório:");
            Console.Write("Carro (código): ");
            int cod = int.Parse(Console.ReadLine());

            int posisao = MainClass.listaCarros.FindIndex(x => x.codigo == cod);
            if (posisao == -1){

                throw new ModeloExcessao("O codigo " + cod + "o carro não encontrado!");
            }

            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Carro carro = MainClass.listaCarros[posisao];

            Acessorio acessorio = new Acessorio(descricao, preco, carro);

            carro.acessorios.Add(acessorio);
     
        }

        public static void MostrarDetalheCarro()
        {
            Console.Write("Digite o código do carro: ");
            int codigo = int.Parse(Console.ReadLine());

            int posisao = MainClass.listaCarros.FindIndex(x => x.codigo == codigo);

            if (posisao == -1){
                throw new ModeloExcessao("Codigo do carro nao encontrado");
            }

            Carro carro = MainClass.listaCarros[posisao]; 

            Console.WriteLine(carro);

            Console.WriteLine("Acessórios: ");

            for (int i = 0; i < carro.acessorios.Count; i++){
                Console.WriteLine(carro.acessorios[i]);
            }

        }
    }
}

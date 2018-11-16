using System;
using System.IO;
using System.Globalization;
using Sessao7Trabalhandoa.entidade;
using System.Text.RegularExpressions;

namespace cap7TrabalhandoArquivo
{
    class MainClass
    {
        public static void Main(string[] args)
        {


     
            gasolinha.programa();


        }






        public void produtos(){
            string diretorio = @"/Users/gilmar/Documents/";
            string sourcePath = diretorio + "gilmar.csv";
            string criaArquivoDiretorio = diretorio + "out";
            string arquivoNovo = criaArquivoDiretorio + "/summery.csv";

            string[] linhas = File.ReadAllLines(sourcePath);

            Directory.CreateDirectory(criaArquivoDiretorio);

            try
            {

                using (StreamWriter sw = File.AppendText(arquivoNovo))
                {

                    foreach (string linha in linhas)
                    {
                        string[] colunas = linha.Split(' ');
                        string nome = colunas[0];
                        double valor = double.Parse(colunas[1], CultureInfo.InvariantCulture);
                        int quantidade = int.Parse(colunas[2]);


                        Produto novo = new Produto(nome, valor, quantidade);

                        sw.WriteLine(novo.nome + ", " + novo.total().ToString("F2", CultureInfo.InvariantCulture));
                    }

                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Exessao na coisa");
                Console.WriteLine(e.Message);
            }
        }


    }
}

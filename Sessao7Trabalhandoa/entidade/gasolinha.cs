using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Sessao7Trabalhandoa.entidade
{
    public class gasolinha
    {
        public string data { get; set; }
        public string odokm { get; set; }
        public string fuelLitres { get; set; }
        public string full { get; set; }
        public string PriceOptional { get; set; }
        public string kmloptional { get; set; }
        public string latitudeOptional { get; set; }
        public string longitudeOptional { get; set; }
        public string cityOptional { get; set; }
        public string notesOptional { get; set; }
        public string missed { get; set; }
        public string tankNumber { get; set; }
        public string fuelType { get; set; }
        public string volumePrice { get; set; }
        public string stationIDOptional { get; set; }
        public string excludeDistance { get; set; }
        public string uniqueId { get; set; }
        public string tankCalc { get; set; }

        public gasolinha(string data, string odokm, string fuelLitres, string full, string PriceOptional, string missed, string volumePrice, string uniqueId)
        {
            this.data = formataData(data);
            this.odokm = odokm;
            this.fuelLitres = fuelLitres;
            this.full = full;
            this.PriceOptional = PriceOptional;
            this.kmloptional = "0.0";
            this.latitudeOptional = "0";
            this.longitudeOptional = "0";
            this.cityOptional = "";
            this.notesOptional = "";
            this.missed = missed;
            this.tankNumber = "1";
            this.fuelType = "0";
            this.volumePrice = volumePrice;
            this.stationIDOptional = "0";
            this.excludeDistance = "0";
            this.uniqueId = uniqueId;
            this.tankCalc = "0.0";
        }

        public string formataData(string nome)
        {

            nome = nome.Insert(4, "-");
            nome = nome.Insert(7, "-");
            return nome;
        }

        public static void programa()
        {


            string diretorio = @"/Users/gilmar/Documents/";
            string sourcePath = diretorio + "original.csv";
            string criaArquivoDiretorio = diretorio + "out";
            string arquivoNovo = criaArquivoDiretorio + "/atualizado.csv";

            string[] linhas = File.ReadAllLines(sourcePath);

            Directory.CreateDirectory(criaArquivoDiretorio);

            try
            {
                List<gasolinha> gs = new List<gasolinha>();

                using (StreamWriter sw = File.AppendText(arquivoNovo))
                {
                    int contador = 1;
                    foreach (string linha in linhas)
                    {
                        string nome = trimGbs(linha);
                        nome = trimAll(nome);
                        
                        string[] colunas = nome.Split(' ');

                        string data = colunas[1];
                        string odokm = colunas[2];
                        string fuelLitre = colunas[3];

                        string full;
                        if (colunas[8] == "4")
                        {
                            full = "0";
                        }
                        else
                        {
                            full = "1";
                        }

                        string PriceOptional = colunas[5];

                        string missed = colunas[17];
                        string volumePrice = colunas[4];


                        gs.Add( new gasolinha(data, odokm, fuelLitre, full, PriceOptional, missed, volumePrice, contador.ToString()));



                        //Console.WriteLine(gs[contador-1]);
                        contador = contador + 1;
                    }
                    Console.WriteLine(gs.Count);

                    for (int i = gs.Count; i > 0; i--){
                        sw.WriteLine(gs[i-1]);
                        Console.WriteLine(gs[i-1]);
                    }

                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Tem algo errado que não esta certo!");
                Console.WriteLine(e.Message);
            }

        }


        public static String trimAll(String text)
        {
            String strings = text.Trim();
            while (strings.Contains("  "))
            {
                strings = strings.Replace("  ", " ");
            }
            return strings;
        }

        public static String trimGbs(String text)
        {
            String strings = text.Trim();
            while (strings.Contains("\t"))
            {
                strings = strings.Replace("\t", " ");
            }
            return strings;
        }


        public override string ToString()
        {
            return "\"" + data + "\",\""
                + odokm + "\",\""
                + fuelLitres + "\",\""
                + full + "\",\""
                + PriceOptional + "\",\""
                + kmloptional + "\",\""
                + latitudeOptional + "\",\""
                + longitudeOptional + "\","
                + cityOptional + ",\""
                + notesOptional + "\",\""
                + missed + "\",\""
                + tankNumber + "\",\""
                + fuelType + "\",\""
                + volumePrice + "\",\""
                + stationIDOptional + "\",\""
                + excludeDistance + "\",\""
                + uniqueId + "\",\""
                + tankCalc + "\"";


        }
    }
}

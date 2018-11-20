using System;
using System.Globalization;
using cap8_Interfaces.Entidades;
using cap8_Interfaces.Servico;

namespace cap8_Interfaces
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com dados do contrato");
            Console.Write("Contrato: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Data (dd/mm/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Valor do contrato: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre o numero de parcelas: ");
            int parcela = int.Parse(Console.ReadLine());



            Contrato myContract = new Contrato(numero, data, valor);

            ContratoServico contractService = new ContratoServico(new PayPalServico());
            contractService.processarContrato(myContract, parcela);

            Console.WriteLine("Installments:");
            foreach (Parcela p in myContract.parcelas)
            {
                Console.WriteLine(p);
            }



        }
    }
}

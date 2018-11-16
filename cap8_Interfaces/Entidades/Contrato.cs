using System;
namespace cap8_Interfaces.Entidades
{
    //contract
    public class Contrato
    {
        public int numero { get; set; } //number
        public DateTime data { get; set; } //date
        public double totalValor { get; set; } //totalValue

        public Contrato(int numero, DateTime data, double totalValor)
        {
            this.numero = numero;
            this.data = data;
            this.totalValor = totalValor;
        }


    }
}

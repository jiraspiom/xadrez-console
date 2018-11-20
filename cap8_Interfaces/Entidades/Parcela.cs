using System;
using System.Globalization;

namespace cap8_Interfaces.Entidades
{
    //installment
    public class Parcela 
    {

        public DateTime dataVencimento { get; set; } //dueDate
        public double quantidade { get; set; }       //amount

        public Parcela(DateTime dataVencimento, double quantidade)
        {
            this.dataVencimento = dataVencimento;
            this.quantidade = quantidade;
        }

        public override string ToString()
        {
            return dataVencimento.ToString("dd/MM/yyyy")
                + " - "
                + quantidade.ToString("F2", CultureInfo.InvariantCulture);
           
        }


    }

    
}

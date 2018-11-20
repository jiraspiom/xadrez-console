using System;
using cap8_Interfaces.Entidades;

namespace cap8_Interfaces.Servico
{
    public class PayPalServico : IOnlinePagamentoServico
    {
         const double FeePercentage = 0.02;
         const double MonthlyInterest = 0.01;

        public double PaymentFee(double quantidade)
        {
            return quantidade * FeePercentage;
        }

        public double Interest(double quantidade, int mes)
        {
            return quantidade * MonthlyInterest * mes;
        }
    }
}

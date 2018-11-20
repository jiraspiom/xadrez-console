using System;
namespace cap8_Interfaces.Entidades
{
    public interface IOnlinePagamentoServico
    {
        double PaymentFee(double amont);
        double Interest(double amount, int months);
    }
}

using System;
using cap8_Interfaces.Entidades;

namespace cap8_Interfaces
{
    public class ContratoServico
    {
        IOnlinePagamentoServico _onlinePaymentService;

        public ContratoServico( IOnlinePagamentoServico onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }


        public void processarContrato(Contrato contrato, int mes)
        {
            double basicQuota = contrato.totalValor / mes;
            for (int i = 1;  i <= mes; i++)
            {
                DateTime data = contrato.data.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contrato.addParcela(new Parcela(data, fullQuota));
            }

        }
    }
}
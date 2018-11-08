using System;
namespace cap4_proposto2.Dominio
{
    public class ModeloExcessao : Exception
    {
        public ModeloExcessao(string mensaguem) : base(mensaguem){

        }
    }
}

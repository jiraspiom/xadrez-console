using System;
using System.Collections.Generic;

namespace cap4_proposto2.Dominio
{
    public class Marca
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string pais { get; set; }
        public List<Carro> carros;

        public Marca(int codigo, string nome, string pais)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.pais = pais;
            carros = new List<Carro>();
        }

        public void addCarro(Carro carro){
            carros.Add(carro);
        }


        public override string ToString()
        {          
            return codigo + ", " + nome + ", País: " +  pais + " Número de carros: " + carros.Count;
        }
    }
}

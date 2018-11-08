using System;
using System.Collections.Generic;

namespace cap4_proposto2.Dominio
{
    public class Carro
    {

        public int codigo { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public double precoBasico { get; set; }
        public Marca marca;
        public List<Acessorio> acessorios;

        public Carro(int codigo, string modelo, int ano, double precoBasico, Marca marca)
        {
            this.codigo = codigo;
            this.modelo = modelo;
            this.ano = ano;
            this.precoBasico = precoBasico;
            this.marca = marca;
            acessorios = new List<Acessorio>();
        }

        public double precoTotal(){
            double total = precoBasico; 

            for (int i = 0; i < acessorios.Count; i++){
                total = total + acessorios[i].preco;
            }
            return total;
        }

        public override string ToString()
        {
            return codigo + ", " + modelo + ", Ano: " + ano + "Preço básico: " + precoBasico + ", Preço total: " + precoTotal() ;
        }

    }
}

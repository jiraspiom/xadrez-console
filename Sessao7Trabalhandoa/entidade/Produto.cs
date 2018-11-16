using System;
namespace Sessao7Trabalhandoa.entidade
{
    public class Produto
    {
        public string nome { get; set; }
        public double valor { get; set; }
        public int quantidade { get; set; }

        public Produto(string nome, double valor, int quantidade)
        {
            this.nome = nome;
            this.valor = valor;
            this.quantidade = quantidade;
        }

        public double total(){
            return valor * quantidade;
        }
    }
}

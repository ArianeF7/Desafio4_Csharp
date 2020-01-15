using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio4_Csharp
{
    class Produto
    {
        private string nome;
        private double preco;
        private int qtd;

        public Produto(string _nome, double _preco, int _qtd)
        {
            this.Nome = _nome;
            this.Preco = _preco;
            this.Qtd = _qtd;
        }

        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Qtd { get; set; }
        
        public void produto()
        {

        }

        public void produto(string nome, double preco, int qtd)
        {

        }

    }
}

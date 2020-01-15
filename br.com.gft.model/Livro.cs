using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio4_Csharp
{
    class Livro: Produto, Imposto
    {
        private string autor;
        private string tema;
        private int qtdPag;

        public Livro(string _nome, double _preco, int _qtd, string _autor, string _tema, int _qtdPag_) : base(_nome, _preco, _qtd)
        {
            this.autor = _autor;
            this.tema = _tema;
            this.qtdPag = _qtdPag_;
        }

        public string Autor { get; set; }
        public string Tema { get; set; }
        
        public int QtdPag
        {
            get
            {
                return this.qtdPag;
            }
            set
            {
                this.qtdPag = value;
            }
        }

        public void livro()
        {

        }

        public void livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag)
        {
            
        }

        public double calculaImposto()
        {
            if (tema == "educativo")
            {
                Console.WriteLine("Livro Educativo não tem imposto: " + this.Nome);
                return 0;
            }
            else
            {
                double imposto = Preco * 0.10;
                Console.WriteLine("R$: " + imposto + " de impostos sobre o livro " + this.Nome);
                return imposto;
            }
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio4_Csharp
{
    class VideoGame: Produto , Imposto
    {
        private string marca;
        private string modelo;
        private bool isUsado;

        public VideoGame(string _nome, double _preco, int _qtd, string _marca, string _modelo, bool _isUsado): base(_nome, _preco, _qtd)
        {
            this.Marca = _marca;
            this.Modelo = _modelo;
            this.IsUsado = _isUsado;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool IsUsado { get; set; }

        public void videoGame()
        {

        }

        public void videoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado)
        {

        }

        public double calculaImposto()
        {
            double imposto;
            if(isUsado == true)
            {
                imposto = Preco * 0.25;
                Console.WriteLine("Imposto " + this.Nome + " " + modelo + " usado, R$: " + imposto);
                return imposto;
            }
            else
            {
                imposto = Preco * 0.45;
                Console.WriteLine("Imposto " + this.Nome + " " + modelo + " R$: " + imposto);
                return imposto;
            }
        }

    }
}

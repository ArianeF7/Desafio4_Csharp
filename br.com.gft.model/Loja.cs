using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio4_Csharp
{
    class Loja
    {
        private string nome;    
        private string cnpj;
        private List<Livro> livros;
        private List<VideoGame> videoGames;

        

        public Loja(string _nome, string _cnpj, List<Livro> _livros, List<VideoGame> _videoGames)
        {
            this.nome = _nome;
            this.cnpj = _cnpj;
            this.livros = _livros;
            this.videoGames = _videoGames;
        }

        public string Nome { get; set;}
        public string Cnpj { get; set;}
        public List<Livro> Livros { get; set;}
        public List<VideoGame> VideoGame {get; set;}
        

        public void loja()
        {

        }
        public void loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGame)
        {

        }

        public void listaLivros()
        {
            if (livros.Count == 0)
            {
                Console.WriteLine("A loja não tem livros no seu estoque.");
            } else {
                Console.WriteLine("A loja " + nome + " possui estes livros para venda:");
                foreach (Livro a in livros)
                {
                    Console.WriteLine("Titulo: " + a.Nome + ", preço: " + a.Preco.ToString("C") + ", quantidade: " + a.Qtd + " em estoque.");
                } 
            }
        }

        public void listaVideoGames()
        {
            if (videoGames.Count == 0)
            {
                Console.WriteLine("A loja não tem video-games no seu estoque.");
            }
            else
            {
                Console.WriteLine("A loja " + nome + " possui estes video-games para venda:");
                foreach (VideoGame a in videoGames)
                {
                    Console.WriteLine("Video-game: " + a.Modelo + ", preço: " + a.Preco.ToString("C") + ", quantidade: " + a.Qtd + " em estoque.");
                }
            }

        }

        
        public double calculaPatrimonio()
        {

            double patrimonio = 0, pt = 0;
            foreach (Livro cont in livros)
            {
                patrimonio += (cont.Preco * cont.Qtd);
            }

            foreach (VideoGame cont in videoGames)
            {
                patrimonio += (cont.Preco * cont.Qtd);
            }

            Console.WriteLine("O patrimonio da loja: "+ nome + " é de R$: " + patrimonio.ToString("C"));
                                    
            return patrimonio;
        }
    }
}

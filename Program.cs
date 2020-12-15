using System;

namespace MetodosConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizando o construtor vazio
            Produto produto1 = new Produto();
            produto1.Codigo = 1;
            produto1.Nome = "Trakinas";
            produto1.Descricao = "Bolacha recheada";
            produto1.Estoque = 500;

            Console.WriteLine($"Produto 1 Codigo {produto1.Codigo}, Nome {produto1.Nome}, Descrição {produto1.Descricao}, Estoque {produto1.Estoque}.");
        
            //Construtor inserindo apenas o código
            Produto produto2 = new Produto(10);
            produto2.Nome = "Passa Tempo";

            Console.WriteLine($"Codigo inserido {produto2.Codigo}, Nome {produto2.Nome}");

            //Construtor inserindo todos os valores 
            Produto produto3 = new Produto(1, "ClubSocial", "Bolacha sem recheio", 500);

            Console.WriteLine($"Codigo {produto3.Codigo}, Nome {produto3.Nome}, Descrição {produto3.Descricao}, Estoque {produto3.Estoque}");

        }//Main
    }
}

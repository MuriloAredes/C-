using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.Colecao
{
    class ColecoesList
    {   public class Produto 
        {
        public string Nome;
        public double Preco;
            public Produto(string nome, double preco) 
            {
                Nome = nome;
                Preco = preco;
            }

                public override bool Equals(object obj)
            {
                Produto outro = (Produto)obj;
                bool mesmoNome = Nome == outro.Nome;
                bool mesmoPreco = Preco == outro.Preco;
                return mesmoNome && mesmoPreco;

            }

            public override int GetHashCode()
            {
                return Nome.Length;
            }

        }
        public static void Executar() 
        {
            var Livro = new Produto("Game of Throne", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(Livro); // aqui é para colocar o elemento carrinho dentro do livro

            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8 temporada game of thrones", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.AddRange(combo);// Esse comando adiciona
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3); // Esse comando remove o parametro no lugar 3 

            foreach (var item in carrinho) 
            {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }
        }   

    }
}

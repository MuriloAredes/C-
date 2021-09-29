using System;
using System.Collections.Generic;
using System.Text;
using static Curso_Csharp.Colecao.ColecoesList;

namespace Curso_Csharp.Colecao
{
    class ColecoesSet
    {   

        
        public static void Executar() 
        {
            var Livro = new Produto("Game of Throne", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(Livro); // aqui é para colocar o elemento carrinho dentro do livro

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8 temporada game of thrones", 99.9),
                new Produto("Poster", 10)
            };

              carrinho.UnionWith(combo);// Esse comando adiciona
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3); // Esse comando remove o parametro no lugar 3 

            foreach (var item in carrinho) 
            {
             //   Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");

                Console.WriteLine(carrinho.Count);
                carrinho.Add(Livro);
                Console.WriteLine(carrinho.Count);
            }
        }   

    }
}

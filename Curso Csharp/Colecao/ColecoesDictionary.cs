using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.Colecao
{
    class ColecoesDictionary
    {   public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000,"Gladiador");
            filmes.Add(2002,"Homem - Aranha");
            filmes.Add(2004,"Os incriveis");
            filmes.Add(2006,"O grande truque");

            if (filmes.ContainsKey(2004))//chave ContainKey
            {
                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));

            }

            Console.WriteLine(filmes.ContainsValue("Amnésia"));// Aqui ele verifica se tem o nome citado no dicionario filme
            
            Console.WriteLine($"Removeu ?{filmes.Remove(2004)}");// Aqui remove o filme  no ano citado 

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"Filme {filme2006}!");

            foreach (var chave in filmes.Keys) 
            {   // apareca apenas as chaves que sao os anos menos o 2004
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values) 
            {   // so mostra os nomes dos filmes
                Console.WriteLine(valor);
            }

            foreach (KeyValuePair<int, string> filme in filmes) 
            {       // Aqui mostra o filme e o ano do filque que é a chave 
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

            foreach (var filme in filmes) 
            {   // imprime da mesma forque que a anterior
                Console.WriteLine($"{filmes.Values} é de {filme.Key}");
            }




        }
    }
}

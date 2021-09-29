using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Curso_Csharp.MetodoEfuncao
{

    class Estudos
    {
        public static void Executar()
        {
            string sorteio;

            List<String> lista = new List<string>();

            lista.Add("Colinho");
            lista.Add("Chapeu");
            lista.Add("Chocolate");
            lista.Add("Gato");
            lista.Add("Sapato");
            lista.Add("santana");

            Random gerador = new Random();
            sorteio = lista[gerador.Next()];

            for (var i = 0; i < 6; i++) 
            {
                Console.WriteLine(sorteio);
            }
            
                
            
        }
    }
}




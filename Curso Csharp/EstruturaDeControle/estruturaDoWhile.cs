using System;











using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.EstruturaDeControle
{
    class estruturaDoWhile
    {
        public static void Executar() 
        {
            string entrada; 
            do {
                Console.WriteLine("Qual o seu nome ?");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem vindo {0}", entrada );
                Console.WriteLine("Deseja continuar ? (S/N) {0}");
                entrada = Console.ReadLine();

            } while (entrada.ToLower() == "s");
        }
           
    }
}

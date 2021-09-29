using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.EstruturaDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random ();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativa = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Insira o seu Palpite");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativa++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("numero encontrado em {0} tentativas", tentativa);
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("menor... tente novamente !");
                    Console.WriteLine("tentativas restantes : {0}", tentativasRestantes);
                }
                else 
                {
                    Console.WriteLine("Maior... tente novamente!");
                    Console.WriteLine("Tentativas restantes : {0}",tentativasRestantes);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.EstruturaDeControle
{
    class UsandoBreak
    {   public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número  que queremos é {0}.", numero);

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("{0} é o numero que  queremos", i );

                if (i == numero)
                {
                    Console.WriteLine("SIM!");
                    break;
                }
                else
                {
                    Console.WriteLine("Não!");
                }
                
            }
            Console.WriteLine("FIM");
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.EstruturaDeControle
{
    class EstruturaIfElse
    { public static void Executar() 
        {
            double nota = 7.0;

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que sua obrigacão...");
            }
            else
            {
                Console.WriteLine("recuperacao [!]");
                Console.WriteLine("Mas esforco da ultima vez !");
            }
        }
    }
}

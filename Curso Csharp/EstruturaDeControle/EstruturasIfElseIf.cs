using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.EstruturaDeControle
{
    interface EstruturasIfElseIf 
    { 
        public static void Executar()
        {
            Console.WriteLine("Digite a nota do aluno ; ");

            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Quadro de honra!");

            }
            else if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
            }
            else if(nota >= 5.0 )
            { 
                Console.WriteLine("recuperacao");
            }
            else { Console.WriteLine("te vejo na proxima"); }
            
            Console.WriteLine("THE END ");  
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.EstruturaDeControle
{
    class EstruturaForEach
    {   public static void Executar() 
        {
            var palavra = "opa!";


            foreach (var letra in palavra) 
            {
                Console.WriteLine(letra); 
            }

            var alunos = new string[] { "Ana", "bia", "carlos" };// criando array
            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

        }
    }
}

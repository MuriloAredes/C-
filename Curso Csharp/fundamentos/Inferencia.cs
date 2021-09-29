using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.fundamentos
{
    class Inferencia
    {   public static void Executar() 
        {
            var nome = "Murilo";
            //var nome = 123 error 
            Console.WriteLine(nome);

            //int idade ;
            var idade = 23; 
            Console.WriteLine(idade);

            int a;
            a = 3;
            Console.WriteLine(a);

            int b = 2;
            Console.WriteLine(a + b);

        }
    }
}

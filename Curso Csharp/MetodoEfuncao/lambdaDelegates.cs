using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.Poo
{
    delegate double operacao(double x, double y);
    class lambdaDelegates
    {public static void Executar() 
        {
            operacao sum = (x, y) => x + y;
            operacao sub = (x, y) => x - y;
            operacao mult = (x, y) => x * y;

            Console.WriteLine(sum(3, 3));
            Console.WriteLine(sub(5, 2));
            Console.WriteLine(mult(3, 3));
        }
    }
}

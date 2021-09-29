using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.fundamentos
{
    class operadoresRelacionais
    { public static void Executar()
        {
            Console.Write("digite a nota");
            //double nota = 6.0;
            double.TryParse(Console.ReadLine(), out double nota);
            double NotaDeCorte = 7.0;

            Console.WriteLine("nota invalida? {0}", nota >10.0);
            Console.WriteLine("nota invalida? {0}", nota < 0.0);
            Console.WriteLine("perfeito? {0}", nota == 10.0);
            Console.WriteLine("tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("passou por media? {0}", nota >= NotaDeCorte);
            Console.WriteLine("recuperacao? {0}", nota < NotaDeCorte);
            Console.WriteLine("reprovado? {0}", nota <= 3.0);
        }
    }
}

using System;
using System.Globalization;

namespace Curso_Csharp.fundamentos
{
    class FormatandoNumero
    { public static void Executar() 
        {
            double valor = 15.175;
            //double valor = 15.00;
            Console.WriteLine(valor.ToString("f1"));
            Console.WriteLine(valor.ToString("c"));
            Console.WriteLine(valor.ToString("p"));
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}

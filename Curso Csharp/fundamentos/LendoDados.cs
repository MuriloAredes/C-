using System;
using System.Globalization;

namespace Curso_Csharp.fundamentos
{
    class LendoDados
    { public static void Executar()
        {
            Console.WriteLine("Qual é seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é seu salario? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}

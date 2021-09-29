using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.MetodoEfuncao
{
    class ExemploLambda
    {   public static void Executar() 
        {
            Action<string> AlgoNoConsole = (a) =>
            {
                Console.WriteLine("Lambda com C#! ");
            };

            AlgoNoConsole("!!!");

            Func<int> jogarDado = () =>
            {
                Random ramdom = new Random();
                return ramdom.Next(1, 7);
                
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");

            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                string.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(1, 1, 2019));
            
        }
    }
}

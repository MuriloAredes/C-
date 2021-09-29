using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.fundamentos
{
    class Conversoes
    { public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(inteiro);

            double nota = 9.7;
            int notatruncada = (int)nota;

            Console.WriteLine("nota truncada : {0}", notatruncada);


            Console.WriteLine("digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida : {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado : {0}", idadeInteiro);

            Console.WriteLine("Digite primerio  numero");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("resultado 1: {0}", numero1);


            Console.WriteLine("Digite segundo numero");
            
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("resultado 2: {0}", numero2);
        }
    }
    }


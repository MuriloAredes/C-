using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.MetodoEfuncao
{
        public static class ExtensoesInteiro 
        {
            public static int Soma(this int num, int outroNumero) 
            {
                return num + outroNumero;
            }

            public static int Subtracao(this int num, int outroNumero) 
            {
                return num - outroNumero;
            }
        }
    class MetodosDeExtensao
    {
        public static void Executar() 
        {
            int numero = 5;
           int numeroReal = 5;

            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numeroReal.Subtracao(10));

            Console.WriteLine(2.Soma(3));
            Console.WriteLine(2.Subtracao(4));

        }
    }
}

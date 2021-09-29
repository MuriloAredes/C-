using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.MetodoEfuncao
{
    class DelegatesComoParametros
    {
        public delegate int operacao(int x, int y);

        public static int Soma(int x, int y) 
        {
            return x + y;
        }

        public static int multiplicar(int x, int y) 
        {
          
            return x + y;
        }

        public static string Calculadora(operacao op, int x, int y) 
        {
            var resultado = op(x, y);
            return "resultado " + resultado;
        }
        public static void Executar() 
        {
            operacao subtracao = (int x, int y) => x - y; // instanciando 
            Console.WriteLine(Calculadora(subtracao, 3, 2));
            
            //somando
            Console.WriteLine(Calculadora(Soma, 3, 2));
            //multiplicando
            Console.WriteLine(Calculadora(multiplicar, 2,5));
        }
    }
}

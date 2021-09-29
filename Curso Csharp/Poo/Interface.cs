using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.Poo
{  interface Teste
    {
        bool Bla(string a);
    }
    interface OperacaoBinaria 
    {
        int Operacao(int a, int b);
    }

    class soma : OperacaoBinaria
    {
        public int Operacao(int a, int b) 
        { return a + b;
        }

        public bool bla(string teste)
        {
            return true;
        }
    }

    class Subtracao : OperacaoBinaria 
    {   public int Operacao(int a, int b) 
        {
            return a - b;
        }

        public bool bla(string teste)
        {
            return true;
        }
    }

    class Multiplicacao : OperacaoBinaria 
    {   public int Operacao(int a, int b) 
        {
            return a * b;
        }

        public bool bla(string teste)
        {
            return true;
        }
    }

    class Calculadora 
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> 
        {
            new soma(),
            new Subtracao(),
            new Multiplicacao()

        };

        public string ExecutarOperacoes(int a, int b) 
        {
            string resultado = "";

            foreach (var op in operacoes) 
            {
                resultado += $"{op.GetType().Name} = {op.Operacao(a, b)}\n";
            }

            return resultado;
        }
    }
    class Interface
    {
        public static void Executar() 
        {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);
        }
    }
}

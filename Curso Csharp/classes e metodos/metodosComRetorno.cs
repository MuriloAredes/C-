using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.classes_e_metodos
{   class CalculadoraComun 
    {
        public int Somar(int a, int b) 
        {
            return a + b;
        }
        public int subtrair(int a, int b) 
        {
            return a - b;
        }

        public int multiplicar(int a, int b) 
        {
            return a * b;
        }

        public int divisao(int a, int b) 
        {
            return a / b;
        }
        
    }

    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia somar(int a) 
        {
            memoria += a;

            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) 
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia limpar() 
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() 
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int resultado() 
        {
            return memoria;
        }

    }
    class metodosComRetorno
    {

        public static void Executar() 
        {
           var calcudoraComun = new CalculadoraComun();
            var resultado = calcudoraComun.Somar(5, 5);
            // var resultado1 =CalculadoraComun.multiplicar(10,2);

            Console.WriteLine(resultado);
            Console.WriteLine(calcudoraComun.multiplicar(5, 2)); 
            Console.WriteLine(calcudoraComun.subtrair(5, 2)); 
            Console.WriteLine(calcudoraComun.divisao(5, 2));

            var CalculadoraCadeia = new CalculadoraCadeia();
            CalculadoraCadeia.somar(3).Multiplicar(3).Imprimir()
                .limpar().Imprimir();

            resultado = CalculadoraCadeia.somar(3).Multiplicar(3).resultado();
            Console.WriteLine(resultado);
        }
        
    }
    
}

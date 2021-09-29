using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.classes_e_metodos
{
    public class CalculadoraEstatica
    {
        public int somar(int a, int b) //Metodo não Statico
        { return a + b; }
      
        public static int Multiplicar(int a, int b) // Metodo Statico
        { return a * b; }


    }


    class MetodoEstatico 
    {
        public static void Executar() 
        {
            var resultado = CalculadoraEstatica.Multiplicar(2,2);// METODO STATICO  NAO PRECISA INSTANCIAR 
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica(); // METODO NÃO STATICO PRECISA FAZER UMA INSTANCIA USANDO NEW
            Console.WriteLine(calc.somar(2,2));
        }
    }
}

       
    
    


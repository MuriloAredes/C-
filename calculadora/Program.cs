using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULADORA
{
    class Program
    {
        static void main(string[] args)
        {

            Console.WriteLine("calculadora {0} ", Console.Title );
            Console.WriteLine("========================calculadora=======================");


            double valor1 = 0, valor2 = 0, resultado, numero;
            String operador, ValorDigitado;
            bool numerosInteiros;


            // Nesse ponto ele capta o valor 
            Console.WriteLine("Digite o valor 1");
            ValorDigitado = Console.ReadLine();

            // ele verifica se é numero 
            numerosInteiros = double.TryParse(ValorDigitado, out numero);

            if (numerosInteiros)
            {
                valor1 = Math.Round(double.Parse(ValorDigitado), 4);
            }
            else {
                Console.WriteLine("Digite um número válido");
            }

            Console.WriteLine("Digite a operação (' / | + | * | - | %(MOD)'): ");
            operador = Console.ReadLine();

            Console.WriteLine("Digite o 2 valor: ");
            ValorDigitado = Console.ReadLine();

            numerosInteiros = double.TryParse(ValorDigitado, out numero);

            if (numerosInteiros)
            {
                valor2 = Math.Round(double.Parse(ValorDigitado), 4);
            }
            else
            {
                Console.WriteLine("Digite um número válido");
            }


            switch (operador)
            {
                case "+":
                    resultado = Math.Round(valor1 + valor2, 4);
                    Console.WriteLine($"{ valor1 } {'+'} { valor2 } = {resultado}");
                    break;
                case "-":
                    resultado = Math.Round(valor1 - valor2, 4);
                    Console.WriteLine($"{ valor1 } {'-'} { valor2 } = {resultado}");
                    break;
                case "*":
                    resultado = Math.Round(valor1 * valor2, 4);
                    Console.WriteLine($"{ valor1 } {'*'} { valor2 } = {resultado}");
                    break;
                case "/":
                    resultado = Math.Round(valor1 / valor2, 4);
                    Console.WriteLine($"{ valor1 } {'/'} { valor2 } = {resultado}");
                    break;
                case "%":
                    resultado = Math.Round(valor1 % valor2, 4);
                    Console.WriteLine($"{ valor1 } {'%'} { valor2 } = {resultado}");
                    break;
                default:
                    Console.WriteLine("Digite uma operação válida");
                    break;

                 }
            Console.ReadKey();
            }
        }

}
using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int B, A;

            Console.WriteLine("Digite um valor");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor");
            B = int.Parse(Console.ReadLine());

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("são multiplos");
            }
            else 
            {
                Console.WriteLine("não são multiplos");
            }
            Console.ReadKey();
        }
    }
}

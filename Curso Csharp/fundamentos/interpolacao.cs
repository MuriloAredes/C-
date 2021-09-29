using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.fundamentos
{
    class interpolacao
    {
        public static void Executar()
        {
            string nome = "notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("o " + nome + " da marca " + marca + " custa " + preco + " .");

            Console.WriteLine("O {0} da marca {1} custa {2} .", nome, marca, preco);

            Console.WriteLine($"A marca {marca} é legal");

            
        }
    }
}

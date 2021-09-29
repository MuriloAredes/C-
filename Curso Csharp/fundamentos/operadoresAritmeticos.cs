using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.fundamentos
{
    class operadoresAritmeticos
    {   public static void Executar() 
        {
            //preco desconto 
            var preco = 100.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preco final é {0}", totalComDesconto);

            //IMC 
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura , 2);
            Console.WriteLine("A sua massa é {0}", imc);


            // numero par / impar 
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par , par %2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);

        }
    }
    
}

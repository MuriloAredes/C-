using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.fundamentos
{
    class variaveisEConstantes
    { public static void Executar() 
        {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //  PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade );

            sbyte saldoDeGols = (sbyte)byte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor int " +menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("populacao brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("Populacao mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("preco do computador " + precoComputador);

            double ValorDeMercadoApple = 1_000_000_000_000_00;
            Console.WriteLine("valor da apple " + ValorDeMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre as estrelas " + distanciaEntreEstrelas );

            char letra = 'b';
            Console.WriteLine("letra " + letra);

            string texto = "seja bem vindo ao curso C#";
            Console.WriteLine(texto);




        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.classes_e_metodos
{
    class membros
    { public static void Executar() 
        {
            pessoa sicrano = new pessoa();
            sicrano.Nome = "Murilo";
            sicrano.Idade = 24;

            //Console.WriteLine($" {sicrano.Nome} tem {sicrano.Idade} anos. ");

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();


            var fulano = new pessoa();
            fulano.Nome = " beto";
            fulano.Idade = 21;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}

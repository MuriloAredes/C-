using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.classes_e_metodos
{   public class Dependente 
    {
        public string Nome;
        public int Idade;

    }
    class ValorVSReferencia
    {
        public static void Executar() 
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente
            {
                Nome = "Murilo",
                Idade = 23
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Nome}");

            copiaDep.Nome = "Beto";
            dep.Idade = 21;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");
        }
    }
}

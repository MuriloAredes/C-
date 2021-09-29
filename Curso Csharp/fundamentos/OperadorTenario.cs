using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.fundamentos
{
    class OperadorTenario
    {public static void Executar()
        {
            var nota = 7.0;
            bool bomComportamento = true;

            string resultado = nota >= 7.0 && bomComportamento ? "aprovado" : "reprovado";

            Console.WriteLine(resultado);
        }
    }
}

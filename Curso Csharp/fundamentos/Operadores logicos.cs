using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.fundamentos
{
    class Operadores_logicos
    {
        public static void Executar() 
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("comprou a Tv de 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("comprou o sorvete ? {0}", comprouSorvete);

            var comprouTV32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("comprou a tv 32 {0}", comprouTV32);

            Console.WriteLine("Mais saudavel? {0}", !comprouSorvete);

        }   
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.classes_e_metodos
{
    class ParametroComValorPadrao
    {   public static int somar(int a = 1, int b = 1) 
        {
            return a + b;
        }
        public static void Executar() 
        {
            ;
            Console.WriteLine(somar(10, 23));
            Console.WriteLine(somar(50));
            Console.WriteLine(somar());
           
        }
    }
}

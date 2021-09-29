using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.classes_e_metodos
{
    class @params
    {
        public static void rececionar(params string[] pessoas) 
        {
            foreach (var pessoa in pessoas) { Console.WriteLine("Ola {0}", pessoa); }
        }
        public static void Executar() 
        {
            rececionar("Murilo","henrique");
        }
    }
}

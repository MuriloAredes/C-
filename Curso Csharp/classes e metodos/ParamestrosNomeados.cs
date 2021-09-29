using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.classes_e_metodos
{   
    class parametrosNomeados {

        public static void Formatar(int dia, int mes, int ano) 
        {
            Console.WriteLine("{0:d2}/ {1:d2}/ {2}", dia, mes, ano);
        }
        public static void Executar() 
        {
            Formatar(mes: 1, dia: 6, ano: 2006);
        }
    }
}

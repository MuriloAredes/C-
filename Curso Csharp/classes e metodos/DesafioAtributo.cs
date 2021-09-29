using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.classes_e_metodos
{
    class DesafioAtributo
    { 
        int a = 10;
        public static void Executar() 
        {
            //Acessar variavel 'a' dentro do metodo Executar

            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
            

        }
    }
}

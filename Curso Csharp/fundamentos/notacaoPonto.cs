using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.fundamentos
{
    class notacaoPonto 
    {
        public static void Executar() 
        {
            var saudacao = "ola ".ToUpper().Insert(3, " world").Replace("world!", "Mundo");
            Console.WriteLine(saudacao);

            Console.WriteLine("teste".Length);
            string  valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}

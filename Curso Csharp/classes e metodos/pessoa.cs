using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.classes_e_metodos
{
    class pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar() 
        {
            return string.Format($"Olá me chamo {Nome} e tenho {Idade} anos. ");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        
        }
    }
}

using System;
using System.Collections;
using System.Text;

namespace Curso_Csharp.Colecao
{
    class ColecaoArrayList
    {   public static void Executar() 
        {
            var arraylist = new ArrayList // Para usar o array list tem que tirar o GENERIC DE USING
            {"palavra",
                3,
                true
            };

            foreach (var item in arraylist) 
            {
                Console.WriteLine("{0} => {1} ", item, item.GetType());
            }
        }
    }
}

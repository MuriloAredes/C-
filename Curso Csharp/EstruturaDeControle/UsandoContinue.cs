﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.EstruturaDeControle
{
    class UsandoContinue
    { public static void Executar() 
        {
            int intervalo = 50;
            Console.WriteLine("Numeros pares entre 1 e {0}", intervalo);

            for (int i = 1; i <= intervalo; i++)
            { if (i % 2 == 1)
                {
                    continue; // continua o code  } 
                }
                Console.WriteLine(i + " ");
            }
           
        }
    }
}

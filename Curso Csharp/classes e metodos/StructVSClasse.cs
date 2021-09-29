using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.classes_e_metodos
{   public struct Sponto 
    {
        public int X;
        public int Y;
    }

    public class Cponto 
    {
        public int X;
        public int Y;
    }
    class StructVSClasse
    {
        public static void Executar() 
        {   //STRUCT !!!!!1
            Sponto ponto1 = new Sponto { X = 1, Y = 3 };
            Sponto copiaPonto1 = ponto1;// Atribuicao por VALOR!!!M 
            ponto1.X = 3;

            Console.WriteLine("ponto 1 X:{0}", ponto1.X);
            Console.WriteLine("Copia ponto 1 X:{0}", copiaPonto1.X);
            //FIM STRUCT!!!!!!

            //Iniciando CLASS
            Cponto ponto2 = new Cponto { X = 2, Y = 4 };
            Cponto copiaPonto2 = ponto2;// atribuicao por referencia
            ponto2.X = 4;
            Console.WriteLine("ponto 2 X:{0}", ponto2.X);
            Console.WriteLine("Copia ponto 2 X:{0}", copiaPonto2.X);

        }
    }
}

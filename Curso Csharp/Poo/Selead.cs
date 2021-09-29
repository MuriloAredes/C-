using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.Poo
{
    sealed class SemFilho 
    {
        public double ValorDaFortuna() 
        {
            return 1_407_033.65;
        }
    }

    //class SouFilho : SemFilho 
    //{

    //}

    class Avo {
        public virtual bool HonrarNomeFamilia() // Metodo virtual
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public override sealed  bool HonrarNomeFamilia()
        {
               
             return true;
            
        }
    }

    class FilhosRebelde : Pai 
    {
        //public new override bool HonrarNomeFamilia() 
        //{
        //    return false;
        //}
    }
    class Selead { 
        public static void Executar() 
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhosRebelde filho = new FilhosRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());

        }
    }
}

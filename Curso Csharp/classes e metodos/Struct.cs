using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.classes_e_metodos
{
    interface Ponto 
    {
        void MoverNaDiagonal(int delta);
       
    }

    struct Coordenada: Ponto{
        public int X;   //Maiuscula
        public int Y;
        public Coordenada(int x, int y) 
        {   //construtor
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta) 
        {
            X += delta;
            Y += delta;
        }
    }

    
    
    class ExemploStruct
    {
        public static void Executar() 
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Cordenada Inicial; ");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            //INSTANCEANDO 
            var coordenadaFinal = new Coordenada(x: 9, y:1);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final:");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);

        }
    }
}

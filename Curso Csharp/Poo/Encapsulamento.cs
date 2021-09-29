using Encapsulamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.Poo
{
    public class FilhoNaoReconhecido : SubCelebridade 
    {
        public new void MeusAcessos() 
        {
            Console.WriteLine("FilhosNaoReconhecido...");
            
            Console.WriteLine(Infopublica);
             Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(UsaMuitoPhotosop);

        }
    }
    public class AmigoDistante 
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos() 
        {
            Console.WriteLine("AmigosDistantes...");

            Console.WriteLine(amiga.Infopublica);
            //Console.WriteLine(amiga.CorDoOlho);
            //Console.WriteLine(amiga.NumeroCelular);
            //Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoFamilia);
            //Console.WriteLine(amiga.UsaMuitoPhotosop);
        }
    }
    class Encapsulamento
    {
        public static void Executar() 
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}

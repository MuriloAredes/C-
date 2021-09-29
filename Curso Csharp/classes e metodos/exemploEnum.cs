using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.classes_e_metodos
{
    class exemploEnum
    {   public enum Genero {Acao, Aventura, Terror, Animacao, Comedia};

        public class Filme 
        {
            public string Titulo;
            public Genero GereroDoFilme;

        }
        public static void Executar() 
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "sharknardo 17";
            filmeParaFamilia.GereroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo, filmeParaFamilia.GereroDoFilme);

        }
    }
}

using System;


namespace Curso_Csharp.Colecão
{ class Array 
    {
        public static void Executar() 
        {
            string[] alunos = new string[5];

            alunos[0] = "Murilo";
            alunos[1] = "Henrique";
            alunos[2] = "Aredes";
            alunos[3] = "Paulo";
            alunos[4] = "Vinicius";

            foreach (var aluno in alunos) 
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas) 
            {
                somatorio += nota;
               
            }

            double media = somatorio / notas.Length;

            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
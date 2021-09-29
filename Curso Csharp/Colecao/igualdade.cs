using System;
using System.Collections.Generic;
using System.Text;
using static Curso_Csharp.Colecao.ColecoesList;

namespace Curso_Csharp.Colecao
{
    class igualdade
    {
        public static void Executar() 
        {
            var p1 = new Produto("caneca", 1.89); //Não são igual pois  P1 E P2 possuem endereco de memoria diferentes comparando as com p1 == p2  resultado é falso
            var p2 = new Produto("caneta", 1.89);
            var p3 = p2; // Aqui apontam para o mesmo local de endereco 

            Console.WriteLine(p1 ==p2);// Falso
            Console.WriteLine(p3 ==p2);// Verdadeiro
            
            Console.WriteLine(p1.Equals(p2));//Falso
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.classes_e_metodos
{   public class produto 
    {   //atributo
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;
        public produto(string nome, double preco, double desconto) // construtor com três parametros
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
            
        }
        public produto() 
        { }

        public double CalcularDesconto() 
        {   //Aqui ele vai calcular o preco com desconto
            return Preco - Preco * Desconto;
        }
    }
    class AtributosEStaticos
    {   public static void Executar() 
        {
            var produto1 = new produto("Caneta",3.2,0.1);

            //chamando construtor padrao
            var produto2 = new produto()
            {
                Nome = "Borracha",
                Preco = 5.3,
            };
            produto.Desconto = 0.5; // statico line 10
            Console.WriteLine("preco com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("preco com desconto: {0}", produto2.CalcularDesconto());
        }
    }
}

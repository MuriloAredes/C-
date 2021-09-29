using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.Poo
{   public class Animal 
    {   public string Nome { get; set; }

        public Animal(string nome) 
        {
            Nome = nome; // Line 18
        }
    }

    public class Cachorro : Animal
    { public double Altura {get; set;}

        public Cachorro(string nome) : base(nome) // Aqui ele esta chamando o construtor base que é o padrao e passa o parametro nome 
        {// Não podemos trocar o  comando base por this porque ele ficara em um siglo chamando o de baixo (line23  this.(nome)) e assim vice versa
         // porem o base ele chama o construtor externo ja o this so fica entre eles
            Console.WriteLine($"Cachorro {nome} inicializado");
        }

        public Cachorro(string nome, double altura) : this(nome)// <<<<<<<
        {
            Altura = altura;
           
        }

        public override string ToString() 
        {// vamos transformar uma instancia em uma string
            return $"{Nome} tem {Altura}cm de altura! ";
        }
    }
    class ConstrutorThis
    {   public static void Executar() 
        {
            var spike = new Cachorro("spike");
            var max = new Cachorro("Max", 40.0);
           
            Console.WriteLine(spike);
            Console.WriteLine(max);
        }
    }
}

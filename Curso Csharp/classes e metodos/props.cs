using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.classes_e_metodos
{   public class CarroOpcional 
    {
        double desconto = 0.1;

        string nome;
        public string Nome //atributo NOME É PRIVADO
        {
            get 
            {
                return "opcional:" +nome;
            }

            set
            {
                nome = value;
            }
        }
        //Propiedade autoimplementada
        public double Preco { get; set; }

        //somente leitura
        public double PrecoComDesconto 
        { get => Preco - (desconto*Preco); // lambda
            
             
        }
        public CarroOpcional() { }

        public CarroOpcional(string nome, double preco) 
        {
            Nome = nome;
            Preco = preco;
        }
    }
    class props
    { public static void Executar() 
        { var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto);

            //op1.PrecoComDesconto =3000;
            var op2 = new CarroOpcional();
            op2.Nome = "Direcão Eletrica";
            op2.Preco = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);
            
            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);


        
        }
    }
}

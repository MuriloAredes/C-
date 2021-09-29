using System;
using System.Collections.Generic;
using System.Text;
using static Curso_Csharp.Poo.Heranca;
using static Curso_Csharp.Poo.Uno;

namespace Curso_Csharp.Poo
{
       public class Carro 
        {
            protected readonly int VelocidadeMaxima;
            int VelocidadeAtual;

            
            public Carro(int velocidadeMaxima) 
            {
                VelocidadeMaxima = velocidadeMaxima;
            }
            protected int AlterarVelocidade(int delta) 
            {
                int novaVelocidae = VelocidadeAtual + delta;

                if (novaVelocidae < 0)
                {
                    VelocidadeAtual = 0;
                }
                else if (novaVelocidae > VelocidadeMaxima)
                {
                    VelocidadeAtual = VelocidadeMaxima;
                }
                else 
                {
                    VelocidadeAtual = novaVelocidae;
                }
                return VelocidadeAtual;
            }

            public virtual int Acelerar()// usando o comando virtuar, quer dizer que esse metodo pode ser reescrito 
            {
                return AlterarVelocidade(5);
            }

            public int Freiar() 
            {
                return AlterarVelocidade(-5);
            }

        
        }
        public class Uno : Carro 
        {
            public Uno() : base(200) //base chama o construtor Pai que é o carro
            {

            }

            public class Ferrari : Carro 
            {
                public Ferrari() : base(350) 
            {
            }
        public override int Acelerar() //Esse metodo subcreve o da line 48
        {
            return AlterarVelocidade(15);
        }
        // ocultar o método da classe pai 
        public new int Freiar()
        {
            return AlterarVelocidade(-15);

        }
            }
    }
    class Heranca
    {

        public static void Executar()
        {
            Console.WriteLine("uno..");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Freiar());
            Console.WriteLine(carro1.Freiar());

            Console.WriteLine("Ferrari....");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Freiar());
            Console.WriteLine(carro2.Freiar());

            Console.WriteLine("Ferrari com tipo carro ...");
            Carro carro3 = new Ferrari(); 
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Freiar());
            Console.WriteLine(carro3.Freiar());
            Console.WriteLine(carro3.Freiar());

            Console.WriteLine("Uno com tipo carro.....");
            carro3 = new Uno();//polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Freiar());
            Console.WriteLine(carro3.Freiar());
            Console.WriteLine(carro3.Freiar());
        }
    }
}


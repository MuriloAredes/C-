using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.Poo
{
    public abstract class Celular 
    {   //Criei um metodo Assistente linha 18
        public abstract string Assistente();

        public string Tocar() 
        {
            return "Trim trim trim...";
        }
    }

    public class Samsung : Celular //Aqui Samsung Herda : Celular
    {  // o metodo Assistente abaixo
        public override string Assistente() 
        {
            return "Olá! Meu nome é Bixby";
        }
    }

    public class Iphone : Celular // herdou celular
    {
        public override string Assistente()  // Este metodo acompanha quando for Abstract
        {
            return "Olá! Meu nome é Siri ";
        }
    }
    class Abstract
    {   public static void Executar()
        {   // Para chamarmos ele ao inves de instanciar temos que  dar o comando new list<Celular>
            var celulares = new List<Celular>
            {
                new Iphone(),
                new Samsung()
            };

            foreach (var Celular in celulares) 
            {
                Console.WriteLine(Celular.Assistente());
            }
        }
    }
}

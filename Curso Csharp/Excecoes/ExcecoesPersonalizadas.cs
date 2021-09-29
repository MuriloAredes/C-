using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.Excecoes
{   public class NegativoException :Exception // criei uma nova classe que herda de Exception
    {
        public NegativoException() {} // construtor padrao PAI

        public NegativoException(string message) : base(message) { }

        public NegativoException(string message, Exception inner)
            : base(message, inner) { }
    }

    public class ImparException : Exception 
    {
        public ImparException(string message) : base(message) { }
    }
    class ExcecoesPersonalizadas
    {   public static int positivoPar() 
        {
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if (valor  % 2 == 1) 
            {
                throw new NegativoException("numero begativo...:("); 
            }

            return valor;
        }
        public static void Executar() 
        {
            try
            {
                Console.WriteLine(positivoPar());
            }
            catch (NegativoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ImparException ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

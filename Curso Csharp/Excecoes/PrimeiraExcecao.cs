using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.Excecoes
{   public class Conta 
    { double Saldo;
        public Conta(double saldo) 
        {
            Saldo = saldo;
        }

        public void Sacar(double valor) 
        {
            if (valor > Saldo) 
            {
                throw new ArgumentException("Saldo insuficiente");
            }
            Saldo -= valor;
        }
    }
    class PrimeiraExcecao
    {
        public static void Executar() 
        {
            var conta = new Conta(1_223.45);

            try
            {// se acontecer algum erro aqui ele ira pular para o CATCH , Se nao ele vai direto para o  FINALLY
                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {   // se o try finalizo sem  algum erro 
                Console.WriteLine("Obrigado");
            }
        }
    }
}

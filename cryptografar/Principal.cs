using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace criptografando
{
    class Principal
    { public static void Main() 
        {
           
            string digSenha  ;
            string digSenhaErr = "henrique";

            // instanciar 
            Hash hash = new Hash(SHA1.Create());

           

            Console.WriteLine("Digite Seu nome ou senha  para cryptografar: ");
            digSenha = Console.ReadLine();



            string senhaEncc = hash.CriptografarSenha(digSenha);
            Console.WriteLine($"senha encrypt {senhaEncc}");
        }
    }
}

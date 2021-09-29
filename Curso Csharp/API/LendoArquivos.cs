using System;
using System.IO;

namespace Curso_Csharp.API
{
    class LendoArquivos
    {
        public static void Executar() 
        {
            var path = @"C:\Users\Muril\Desktop\primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path)) // só ira enrar se existir o arquivo 
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto;Preco;Quantidade");
                    sw.WriteLine("Caneta Bic preta;3.59,89");
                    sw.WriteLine("Borracha Branca;2.89;27");
                }

                try 
                {
                    using (StreamReader sr = new StreamReader(path)) 
                    {
                        var texto = sr.ReadToEnd();
                        Console.WriteLine(texto);
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }
    }
}

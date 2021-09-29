using System;
using System.IO;
namespace Curso_Csharp.API
{   public static class ExtensaoString 
    {
        public static string ParseHome(this string path) 
        {   // Aqui ele vai saber  se ao ambiente é linux ou mac
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME") : Environment.ExpandEnvironmentVariables("%HOMEDRIVER%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
     class PrimeiroArquivo
    {
        public static void Executar() 
        {
            var path = @"C:\Users\Muril\Desktop\primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path)) 
            {
                using (StreamWriter sw = File.CreateText(path)) 
                {
                    sw.WriteLine("Esse é ");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("Arquivo");    
                }

                using (StreamWriter sw = File.AppendText(path))
                {
                    Console.WriteLine("");
                    Console.WriteLine("É possivel");
                    Console.WriteLine("Adicionar mais texto");
                }
            }
        }
    }
}

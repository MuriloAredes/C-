
using System;
using System.Globalization;

namespace uri1002
{
    class exercicio1
    {
        static void Main(string[] args)
        {
            double area1, area2, area3;
            double raio1, raio2, raio3;
            double PI = 3.14159;

            Console.Write("Digite o numero 1 : ");
            raio1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o numero 2 : ");
            raio2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o numero 3 : ");
            raio3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area1 = PI * raio1 * raio1;
            area2 = PI * raio2 * raio2;
            area3 = PI * raio3 * raio3;

            Console.WriteLine("A=" + area1.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A=" + area2.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A=" + area3.ToString("F4", CultureInfo.InvariantCulture));


        }
    }
}
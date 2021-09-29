using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp
{
    class Carro { //CONSTRUTOR  PADRAO
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = modelo;
            Ano = ano;

        }
        public Carro() { }
    }
    //FIM DE CONSTRUTOR

   
    class construtores
    {
        public static void Executar() 
        {// ACRESCENTANDO VALORES DENTRO DE CARROS 
            var carro1 = new Carro();//INSTANCIA
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("ka", "ford", 2018);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            var carro3 = new Carro()
            {
                Fabricante = "fiat",
                Modelo = "Uno",
                Ano = 2019

            };

            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");



        }
    }
}

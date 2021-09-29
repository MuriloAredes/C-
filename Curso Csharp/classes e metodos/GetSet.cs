using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Csharp.classes_e_metodos
{
    class GetSet
    {

        public class Moto 
        {   //Atributos
            private string Marca;
            private string Modelo;
            private uint Cilindrada;

            //construtor
            public Moto(string marca, string modelo, uint cilindrada) 
            {
                // Marca = marca;
                //  Modelo = modelo;
                //Cilindrada = cilindrada;

                SetMarca(marca);
                SetModelo(modelo);
                SetCilindrada(cilindrada);
            }
            public Moto() { }

            public string GetMarca() 
            {
                return Marca;
            }

            public void SetMarca(string marca) 
            {
                Marca = marca;
            }

            public string GetModelo() 
            {
                return Modelo;
            }

            public void SetModelo(string modelo) 
            {
                Modelo = modelo;
            }

            public uint GetCilindrada() 
            {
                return Cilindrada;
            }

            public void SetCilindrada(uint cilindrada)
            {   // primeira opcao
                //   if(cilindrada > 0) 
                //    {
                //        Cilindrada = cilindrada;
                //    }

                // Segunda opcao
                //Cilindrada = Math.Abs(cilindrada);
                Cilindrada = cilindrada;

            }

        }
        public static void Executar() 
        {
            var moto1 = new Moto("kawasaki", "ninja ZX-6R", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG titan");
            moto2.SetCilindrada(150);
            Console.WriteLine(moto2.GetMarca()+ " " + moto2.GetModelo());
            Console.WriteLine(moto2.GetCilindrada());

        }
        

    }
}

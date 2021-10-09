using System;

namespace Veterinaria
{
    class Animal
    {

        private string nombre;
        private int edad;
        private int peso;


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value <= 0)
                {

                    Console.WriteLine("La edad que introdujo no es válida, ingrese una edad válida por favor ");
                }
                else { edad = value; }
            }
        }

        public int Peso
        {
            get { return peso; }
            set
            {
                if (value <= 0)
                {

                    Console.WriteLine("Peso introducido no válido");
                }
                else { peso = value; }
            }
        }


    }
    class Perro : Animal
    {

        private string tipocomestible;
        private string raza;

        public string Tipocomestible
        {
            get { return tipocomestible; }
            set { tipocomestible = value; }
        }

        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }


        class Program

        {
            static void Main(string[] args)
            {
                Perro p = new Perro();

                Console.WriteLine("Nombre del perro: ");
                p.Nombre = Console.ReadLine();
                Console.WriteLine("Edad del perro: ");
                p.Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Peso del perro: ");
                p.Peso = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Raza del perro: ");
                p.Raza = Console.ReadLine();
                Console.WriteLine("Tipo de alimento: ");
                p.Tipocomestible = Console.ReadLine();

                //Datos de salida

                Console.WriteLine("\n Datos Finales \n");
                Console.WriteLine("Nombre: {0}", p.Nombre);
                Console.WriteLine("Edad: {0}", p.Edad);
                Console.WriteLine("Peso: {0}", p.Peso);
                Console.WriteLine("Raza: {0}", p.Raza);
                Console.WriteLine("Tipo de Alimento: {0}", p.Tipocomestible);
            }
        }
    }
}

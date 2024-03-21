using System;

namespace PiramideNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuantas Filas quieres que tenga la piramide?");
            int tam = Convert.ToInt32(Console.ReadLine());

            //Creamos el objeto de la clase Piramide
            Piramide objPiramide = new Piramide(tam);

            //Imprimimos la piramide
            objPiramide.CrearPiramide();

            
            Console.Read();
        }
    }
}

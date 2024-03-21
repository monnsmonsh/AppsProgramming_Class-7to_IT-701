using System;

namespace CalcularPotencia
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine();
            Console.WriteLine("-------- Potencia ---------");
            Console.WriteLine("Ingresa el número");
            Console.Write(" R=");
            double numero = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el exponente");
            Console.Write(" R=");
            double exponente = double.Parse(Console.ReadLine());
            Console.Write("");

            //Creamos el objeto de la clase Temperatura.
            OperacionExponente objExponent = new OperacionExponente(numero, exponente);

            //Mandamos llamar metodos.
            Console.WriteLine(objExponent.realizarOperacion());

            //
            Console.ReadLine();
        }
    }
}

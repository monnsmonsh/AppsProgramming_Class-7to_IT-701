using System;

namespace TemperaturaAgua
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("-------Estado del agua----------");
            System.Console.Write("Cual es la temperatura del agua: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------");

            //Creamos el objeto de la clase Temperatura.
            Temperatura objTemperatura = new Temperatura(temp);


            //Monstramos el estado del agua
            objTemperatura.EstadoAgua();

            Console.ReadLine();
        }
    }
}

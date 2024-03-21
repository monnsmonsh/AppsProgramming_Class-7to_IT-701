using System;

namespace SecuenciaFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("-------- Secuencia Fibonacci ---------");
            Console.WriteLine(" ¿Cuantos numeros de la secuencia fibonacci quieres ver?");
            Console.Write(" R= ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            //Creamos el objeto de la clase Fibonacci.
            Fibonacci objSerie = new Fibonacci(x);
            
            //Monstramos numeros impares
            objSerie.SecuenciaFibonacci();

            Console.Read();
        }
    }
}

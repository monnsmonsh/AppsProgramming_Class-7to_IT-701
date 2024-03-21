using System;

namespace NumPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" -------- Numeros Primos ---------");
            Console.WriteLine(" Introduce un numero");
            Console.Write(" R= ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            //Creamos el objeto de la clase Identificar.
            Identificar objIdentificar = new Identificar(num);

            //Monstramos si es primo o no.
            objIdentificar.CalcularPrimo();

            Console.ReadLine();
        }
    }
}

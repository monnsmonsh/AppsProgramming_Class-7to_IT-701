using System;

namespace Ecuaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Captura de datos.
            Console.WriteLine();
            Console.WriteLine(" ------ Ecuacion de Y W Z-------");
            Console.WriteLine(" Valor de a: ");
            Console.Write(" R=");
            double numA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Valor de b: ");
            Console.Write(" R=");
            double numB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            //Creamos un objeto de la clase ecuacion.
            OperacionEcuaciones objEcuacion = new OperacionEcuaciones(numA, numB);

            Console.WriteLine(" Resultados");
            //Monstramos resultados de Y W Z
            objEcuacion.ResultadoY();
            objEcuacion.ResultadoW();
            objEcuacion.ResultadoZ();

            Console.Read();
        }
    }
}

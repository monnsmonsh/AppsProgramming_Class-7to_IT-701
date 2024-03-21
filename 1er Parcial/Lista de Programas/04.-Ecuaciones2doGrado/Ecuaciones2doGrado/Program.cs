using System;

namespace Ecuaciones2doGrado
{
    class Program
    {
        static void Main(string[] args){
            //Captura de datos.
            Console.WriteLine();
            Console.WriteLine(" ------ Ecuacion de 2do Grado -------");
            Console.WriteLine(" Valor de a: ");
            Console.Write(" R=");
            double numA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Valor de b: ");
            Console.Write(" R=");
            double numB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Valor de c: ");
            Console.Write(" R=");
            double numC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            //Creamos un objeto de la clase ecuacion.
            OperacionEcuacion2doGrado objEcuacion = new OperacionEcuacion2doGrado(numA,numB,numC );


            Console.WriteLine(" Resultados");
            //Monstramos resultados de x1 y x2
            objEcuacion.X1();
            objEcuacion.X2();

            Console.Read();
        }


    }
}

using System;

namespace Ecuaciones2doGrado
{
    class Program
    {
        static void Main(string[] args){
            //Captura de datos.
            Console.WriteLine("Valor de a: ");
            double numA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor de b: ");
            double numB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor de c: ");
            double numC = Convert.ToDouble(Console.ReadLine());


            //Creamos un objeto de la clase ecuacion.
            OperacionEcuacion2doGrado objEcuacion = new OperacionEcuacion2doGrado(numA,numB,numC );

            

            //Resultado
            Console.Write("El resultado de x1 es: " + objEcuacion.X1());
            Console.WriteLine();
            Console.Write("El resultado de x2 es: " + objEcuacion.X2());
            Console.Read();
        }


    }
}

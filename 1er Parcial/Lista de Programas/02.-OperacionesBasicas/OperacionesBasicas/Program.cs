using System;

namespace OperacionesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {

            //Captura de datos.
            Console.WriteLine();
            Console.WriteLine( "---- Operacion Basicas ----");
            Console.WriteLine(" Numero 1: ");
            Console.Write(" R=");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Numero 2: ");
            Console.Write(" R=");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            //Creamos un objeto de la clase suma.
            Operaciones objOperaciones = new Operaciones(num1, num2);

            Console.WriteLine("Resultados");
            //Monstramos operaciones
            objOperaciones.Sumar();
            objOperaciones.Restar();
            objOperaciones.Multiplicar();
            objOperaciones.Dividir();


        }
    }
}

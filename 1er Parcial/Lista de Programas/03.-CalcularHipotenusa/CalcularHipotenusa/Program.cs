using System;

namespace CalcularHipotenusa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine();
            Console.WriteLine(" -------- Calcular Hipotenusa---------");
            Console.WriteLine(" Dame el valor de A");
            Console.Write(" R=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Dame el valor de B");
            Console.Write(" R=");
            double b = Convert.ToDouble(Console.ReadLine());

            //Creamos el objeto de la clase Ecuacion.
            Ecuacion objformula = new Ecuacion(a, b);

            //Imprimimos el valor
            objformula.CalcularHipotenusa();

            //Detener Consola.
            Console.Read();
        }
    }
}

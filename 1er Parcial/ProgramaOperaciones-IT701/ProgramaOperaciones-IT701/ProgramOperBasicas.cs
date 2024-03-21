using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaOperaciones_IT701
{
    class ProgramOperBasicas
    {
        static void Main(string[] args)
        {
            //Creamos un objeto de la clase suma.
            OperacionesBasicas objSuma = new OperacionesBasicas();

            //Captura de datos.
            Console.WriteLine("Numero 1: ");
            objSuma.Num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Numero 2: ");
            objSuma.Num2 = Convert.ToDouble(Console.ReadLine());

            //Resultado
            Console.Write("La suma de los dos numeros es: " + objSuma.Num1 + " + " + objSuma.Num2 + " = " + objSuma.Sumar());
            Console.WriteLine();
            Console.Write("La resta de los dos numeros es: " + objSuma.Num1 + " - " + objSuma.Num2 + " = " + objSuma.Restar());
            Console.WriteLine();
            Console.Write("La multiplicacion de los dos numeros es: " + objSuma.Num1 + " * " + objSuma.Num2 + " = " + objSuma.Multiplicar());
            Console.WriteLine();
            Console.Write("La divicion de los dos numeros es: " + objSuma.Num1 + " / " + objSuma.Num2 + " = " + objSuma.Dividir());
            Console.Read();
        }
    }
}

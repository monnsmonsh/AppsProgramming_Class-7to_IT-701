using System;

namespace LeerNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" -------- Leer numero --------- ");
            Console.WriteLine(" Este programa sirve para arrojar las letras del numero que ingreses");
            Console.WriteLine(" Introduce un numero:  ");
            Console.Write(" R=");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Creamos el objeto de la clase Temperatura.
            NumLetras objNumLetras = new NumLetras(num);

            //Monstramos numeros escritos
            Console.WriteLine(objNumLetras.toText(num));


            Console.ReadLine();
        }
    }
    
}

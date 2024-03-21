using System;

namespace NumeroParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" -------- Numeros Par ó Impar ---------");
            Console.WriteLine(" Ingresa un número para saber si es par o es impar ");
            Console.Write(" R=");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            //Creamos el objeto de la clase ParImpar.
            ParImpar objParImpar = new ParImpar(num);

            //Monstramos numeros impares
            objParImpar.NumParImpar();

            Console.ReadLine();
        }
    }
}

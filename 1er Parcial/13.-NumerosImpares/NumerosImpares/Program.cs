using System;

namespace NumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {/*
            //
            Console.Write("¿Cuantos numeros quieres captirar? ");
            int tam = Int32.Parse(Console.ReadLine());

            //Creamos el objeto de la clase ArregloNumeros.
            arreglo objArreglo = new arreglo(tam);

            //Mandar llamar a los metodos para capturar los numeros.
            objArreglo.imparares();
            */



            Console.WriteLine();
            Console.WriteLine("-------- Numeros Impares ---------");
            System.Console.Write("Cuantos numeros primos mostramos:  ");
            int numMostrar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("----------------------------------");


            //Creamos el objeto de la clase Temperatura.
            NumImpares objNumerosInpares = new NumImpares(numMostrar);

            //Monstramos numeros impares
            objNumerosInpares.Contador();

            Console.ReadLine();
        }
    }
}

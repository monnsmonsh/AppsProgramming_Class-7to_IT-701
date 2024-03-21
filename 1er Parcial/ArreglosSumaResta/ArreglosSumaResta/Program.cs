using System;

namespace ArreglosSumaResta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Capturamos cuantos numeros se van a manejar
            Console.Write("¿Cuantos numeros quieres captirar? ");
            int tam = Int32.Parse(Console.ReadLine());

            //Creamos el objeto de la clase ArregloNumeros.
            OperacionesArreglos objArreglo = new OperacionesArreglos(tam);

            //Mandar llamar a los metodos para capturar los numeros.
            objArreglo.CapturarArregloN1();
            objArreglo.CapturarArregloN2();

            //Llamamos al metodo para imprimir el arreglo
            objArreglo.MonstrarArregloN1();
            objArreglo.MonstrarArregloN2();

            //Llamamos al suma de los arreglos
            objArreglo.MonstrarSuma();

            //Llamamos al suma de los arreglos
            objArreglo.MonstrarResta();

            //Llamamos al promedio de los arreglos
            Console.ReadLine();
        }
    }
}

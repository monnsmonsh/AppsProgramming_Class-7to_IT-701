using System;
using System.Collections.Generic;
using System.Text;

namespace ManejoArreglos
{
    class ProgramaArreglosPOO
    {
        static void MainX(string[] args)
        {
            //Capturamos cuantos numeros se van a manejar
            Console.Write("¿Cuantos numeros quieres captirar? ");
            int tam = Int32.Parse(Console.ReadLine());

            //Creamos el objeto de la clase ArregloNumeros.
            ArregloNumeros objArreglo = new ArregloNumeros(tam);

            //Mandar llamar a los metodos para capturar los numeros.
            objArreglo.CapturarArreglo();

            //Llamamos al metodo para imprimir el arreglo
            objArreglo.MonstrarArreglo();

            //Llamamos al suma de los arreglos
            objArreglo.SumaArreglos();

            //Llamamos al promedio de los arreglos
            objArreglo.PromedioArreglos();
        }
    }
}

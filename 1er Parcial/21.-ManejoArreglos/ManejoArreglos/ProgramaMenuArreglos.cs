using System;
using System.Collections.Generic;
using System.Text;

namespace ManejoArreglos
{
    class ProgramaMenuArreglos { 
        static void Main(string[] args)
        {
            
            do
            {
                //Captura de datos del objeto
                System.Console.WriteLine(" PROGRAMA Arreglos");
                System.Console.WriteLine("¿Que tipo de arreglo quieres generar? ");
                System.Console.WriteLine("1.-Capturar Arreglo");
                System.Console.WriteLine("2.-Monstrar Arreglo");
                System.Console.WriteLine("3.-Ordenar de  - a +");
                System.Console.WriteLine("4.-Ordenar de  + a +");
                System.Console.WriteLine("5.Buscar numero");
                System.Console.WriteLine("6.-Suma resta y promedio");
                System.Console.WriteLine("7.-Salir");
                String eleccion = System.Console.ReadLine();
                int valor = Convert.ToInt32(eleccion); //valor del objeto
                System.Console.WriteLine("--------------------------------------");

                switch (valor)
                {
                    case 1://Eleccion de Insertar n numero de arreglos
                           //Capturamos cuantos numeros se van a manejar
                        Console.Write("¿Cuantos numeros quieres captirar? ");
                        int tam = Int32.Parse(Console.ReadLine());
                        //Creamos el objeto de la clase ArregloNumeros.
                        ArregloNumeros objArreglo = new ArregloNumeros(tam);
                        //Mandar llamar a los metodos para capturar los numeros.
                        objArreglo.CapturarArreglo();
                        break;
                    case 2://Eleccion de mostrar n numero de arreglos
                        ArregloNumeros objArreglo2 = new ArregloNumeros();
                        objArreglo2.MonstrarArreglo();
                        break;

                    case 3://Eleccion de Ordenar de  - a +
                        ArregloNumeros objArreglo3 = new ArregloNumeros();
                        objArreglo3.MonstrarMenorMayor();
                        break;
                    case 4://Eleccion de Ordenar de  - a +
                        ArregloNumeros objArreglo4 = new ArregloNumeros();
                        objArreglo4.MonstrarMayorMenor();
                        break;

                    case 5://Eleccion Buscar arreglo
                        ArregloNumeros objArreglo5 = new ArregloNumeros();
                        objArreglo5.BuscarArreglos();
                        break;
                    case 6://Eleccion Buscar arreglo
                        ArregloNumeros objArreglo6 = new ArregloNumeros();
                        objArreglo6.SumaArreglos();
                        objArreglo6.PromedioArreglos();
                        break;
                    default:
                        System.Console.WriteLine("Eleccion no validad");
                        break;
                }

            } while (false);
            Console.Read();
        }
        
    }
}

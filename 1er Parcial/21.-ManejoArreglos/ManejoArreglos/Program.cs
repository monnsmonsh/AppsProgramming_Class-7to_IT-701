using System;

namespace ManejoArreglos
{
    class Program
    {
        static void Mainx(string[] args)
        {
            








            //Creando un arreglo de num. enteros de 10 posiciones
            int[] numeros = new int[10];

            //Capturando los numeros del arreglo.
            for (int i=0; i<numeros.Length; i++){
                Console.Write(" Escribe un numero:  ");
                numeros[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(numeros);//Ordena el arreglo de -a +.

            //Imprimimos los numeros del arreglo
            for(int i=0; i<numeros.Length; i++){
                Console.WriteLine(" Numeros [" + i + "] = "+ numeros[i]);
            }
            Console.Read();
            Array.Reverse(numeros);//Ordena el arreglo de + a --

            //Impresion utilizando un ciclo foreach
            foreach(int numero in numeros){
                Console.WriteLine("Numeros [] " + numero);
            }
            Console.Read();

        }
    }
}

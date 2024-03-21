using System;
using System.Collections.Generic;
using System.Text;

namespace ManejoArreglos
{
    class ArregloNumeros
    {
        //Atributos de la clase.
        private int[] numeros;

        //Constructores
        public ArregloNumeros() { }

        public ArregloNumeros(int tam)
        {
            this.numeros = new int[tam];
        }

        //Propiedades get y set
        public int [] Numeros { get => numeros; set => numeros = value; }

        //Metodos
        public void CapturarArreglo()
        {
            //Capturando los numeros del arreglo.
            for(int i=0; i<numeros.Length; i++)
            {
                Console.Write("Captura un numero: ");
                numeros[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public void MonstrarArreglo()
        {
            //Imprimimos los numeros del arreglo
            for(int i=0; i<numeros.Length; i++)
            {
                Console.WriteLine("Numeros[" + i + "] = " + numeros[i]);
            }
            Console.ReadLine();
        }
        public void MonstrarMenorMayor ()
        {
            //Imprimimos los numeros del arreglo
            Array.Sort(numeros);//Ordena el arreglo de -a +.
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Numeros[" + i + "] = " + numeros[i]);
            }
            Console.ReadLine();
        }
        public void MonstrarMayorMenor()
        {
            //Imprimimos los numeros del arreglo
            Array.Reverse(numeros);//Ordena el arreglo de + a --
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Numeros[" + i + "] = " + numeros[i]);
            }
            Console.ReadLine();
        }

        public void BuscarArreglos()
        {
            Console.Write("Que numero buscar: ");
            int numBuscar = Int32.Parse(Console.ReadLine());
            //Imprimimos los numeros del arreglo
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numBuscar == numeros[i])
                {
                    Console.WriteLine("Tu numero" + numBuscar + "se encuentra en la pocion " + i);
                }

            }
            
            Console.ReadLine();
        }
        public void SumaArreglos()

        {
            int suma = 0;
            //Imprimimos los numeros del arreglo
            for (int i = 0; i < numeros.Length; i++)
            {
                suma = suma + numeros[i];   
               
            }
            Console.WriteLine("La suma de los numeros es: " + suma);
            Console.ReadLine();
        }

        public void PromedioArreglos()
        {
            int suma = 0;
            int div = 0;
           int pro = 0;
            //Imprimimos los numeros del arreglo
            for (int i = 0; i < numeros.Length; i++)
            {
                div =div+ i;
                suma = suma + numeros[i];

            }
            pro = suma / div;
            Console.WriteLine("El promedio es: " + pro);
            Console.ReadLine();
        }
    }
}

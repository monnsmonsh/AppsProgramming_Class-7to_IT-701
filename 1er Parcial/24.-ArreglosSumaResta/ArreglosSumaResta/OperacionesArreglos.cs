using System;
using System.Collections.Generic;
using System.Text;

namespace ArreglosSumaResta
{
    class OperacionesArreglos
    {
        //Atributos de la clase.
        private int[] numero1;
        private int[] numero2;
        private int[] suma;
        private int[] resta;

        //Constructores
        public OperacionesArreglos() { }
        public OperacionesArreglos(int tam)
        {
            this.numero1 = new int[tam];
            this.numero2 = new int[tam];
            this.suma = new int[tam];
            this.resta = new int[tam];
        }

        //Propiedades get y set
        public int[] Numero1 { get => numero1; set => numero1 = value; }
        public int[] Numero2 { get => numero2; set => numero2 = value; }
        public int[] Suma { get => suma; set => suma = value; }
        public int[] Resta { get => resta; set => resta = value; }

        //Metodos
        public void CapturarArregloN1()
        {
            Console.WriteLine("");
            //Capturando los numeros del arreglo (numero1).
            for (int i = 0; i < numero1.Length; i++)
            {
                Console.Write("Captura un numero N1 [" + (i + 1) + "] : ");
                numero1[i] = Int32.Parse(Console.ReadLine());
            }
        }
        public void CapturarArregloN2()
        {
            Console.WriteLine("");
            //Capturando los numeros del arreglo (numero2).
            for (int j = 0; j < numero2.Length; j++)
            {
                Console.Write("Captura un numero N2 [" + (j + 1) + "] : ");
                numero2[j] = Int32.Parse(Console.ReadLine());
            }
        }

        public void MonstrarArregloN1()
        {
            Console.WriteLine("");
            //Imprimimos los numeros del arreglo (numero1).
            for (int i = 0; i < numero1.Length; i++)
            {
                Console.WriteLine("Numero N1[" + i + "] = " + numero1[i]);
            }
        }

        public void MonstrarArregloN2()
        {
            Console.WriteLine("");
            //Imprimimos los numeros del arreglo (numero2).
            for (int j = 0; j < numero2.Length; j++)
            {
                Console.WriteLine("Numero N2[" + j + "] = " + numero2[j]);
            }
        }

        public void MonstrarSuma()
        {
            Console.WriteLine("");
            Console.WriteLine("-------------");
            Console.WriteLine("Las sumas son:");
            Console.WriteLine("-------------");
            for (int i = 0; i < numero1.Length; i++)
            {
                suma[i] = numero1[i] + numero2[i];
            }
            for (int i = 0; i < suma.Length; i++)
            {
                Console.WriteLine("La suma: " + suma[i]);
            }

        }

        public void MonstrarResta()
        {
            Console.WriteLine("");
            Console.WriteLine("-------------");
            Console.WriteLine("Las restas son:");
            Console.WriteLine("-------------");
            for (int i = 0; i < numero1.Length; i++)
            {
                suma[i] = numero1[i] - numero2[i];
            }
            for (int i = 0; i < suma.Length; i++)
            {
                Console.WriteLine("La resta: " + suma[i]);
            }

        }


    }
}

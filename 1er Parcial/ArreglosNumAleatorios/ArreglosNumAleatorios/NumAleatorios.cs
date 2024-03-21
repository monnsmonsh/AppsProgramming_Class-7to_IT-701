using System;
using System.Collections.Generic;
using System.Text;

namespace ArreglosNumAleatorios
{
    class NumAleatorios
    {
        //Atributos de la clase.
        private int[] numAl;
        private int[] contNum;


        //Constructor por omision
        public NumAleatorios(){}
        //Constructor definido por el programador
        public NumAleatorios(int a)
        {
            this.numAl = new int[a];
            this.contNum = new int[a + 1];
        }

        //Propiedades GET y SET.
        public int[] NumAl { get => numAl; set => numAl = value; }
        public int[] ContNum { get => contNum; set => contNum = value; }

        //Metodos.
        public void CapturaArreglo()
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                numAl[i] = r.Next(0, 100);
            }
        }
        public void ContarNum()//Acumulamos la cantidad de veces que aparece cada numero
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 1; j < contNum.Length; j++)
                {
                    if (numAl[i] == j)
                    {
                        contNum[j]++;
                    }
                }
            }
        }
        public void BuscarNum(int x)
        {
            Console.WriteLine("");
            for (int i = 0; i < numAl.Length; i++)
            {
                if (numAl[i] == x)
                {
                    Console.WriteLine("El numero " + x + " se encontro en Arreglo en la posicion [" + i + "]");
                }
            }
        }

        public void MostrarNum()
        {
            for (int i = 0; i < numAl.Length; i++)
            {
                Console.WriteLine("VectorA [" + i + "] = " + NumAl[i]);
            }

            for (int i = 0; i < numAl.Length; i++)
            {
                Console.WriteLine("El numero " + i + " esta " + contNum[i] + " veces");

            }
        }
    }
}

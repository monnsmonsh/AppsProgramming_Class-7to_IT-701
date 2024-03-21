using System;
using System.Collections.Generic;
using System.Text;

namespace NumerosImpares
{
    class NumImpares
    {
        //Atributos de la clase.
        private int numMostrar;

        //Constructores
        public NumImpares() { }

        public NumImpares(int numMostrar)
        {
            this.numMostrar = numMostrar;
        }
        //Propiedades get y set
        public int NumMostrar { get => numMostrar; set => numMostrar = value; }

       
        public void Contador()
        {
            int i = 0;
            int cont = 0;
            int suma = 0;
            int prom = 0;
            int[] numeros = new int[numMostrar];
            do
            {
                cont++;
                if (cont % 2 != 0)
                {
                    numeros[i] = cont;
                    Console.Write(" |" + numeros[i]+"| ");
                    suma = suma + numeros[i];
                    i++;
                }

            } while (i != numMostrar);
            prom = suma / i;
            Console.WriteLine();
            Console.WriteLine("La suma de los numeros impares es :"+suma);

            Console.WriteLine("El promedio de los numeros impares es:" + prom);


        }




    }



    
}

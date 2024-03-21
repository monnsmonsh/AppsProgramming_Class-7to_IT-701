using System;
using System.Collections.Generic;
using System.Text;

namespace PiramideNumeros
{
    class Piramide
    {

        //Atributos de la clase.
        private int tam;
        Random R = new Random();

        //Constructores
        public Piramide() { }
        public Piramide(int tam)
        {
            this.tam = tam;
        }

        //Propiedades get y set
        public int Tam { get => tam; set => tam = value; }


        //Metodos.
        public void CrearPiramide()
        {
            for (int i = 1; i <= tam; i++)
            {
                for (int j = 0; j <= tam - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <=  2 * i - 1; j++)
                {
                    Console.Write(R.Next(0, 9));
                }
                Console.WriteLine();
            }


            /*int k = 0;
            for (int i = 1; i <= k; i++)
            {
                for (int j = 1; j <= k - i; j++)
                    Console.Write("");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("", j);
                Console.Write("");
            }*/
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace NumPrimo
{
    class Identificar
    {
        //Atributos de la clase.
        private int num;
 
        //Constructores.
        public Identificar() { }
        public Identificar(int num)
        {
            this.num = num;
        }
        //Propiedades get y set
        public int Num { get => num; set => num = value; }

        public void CalcularPrimo()
        {
            int a = 0;
            /* z = x / x;
             y = x / 1; */
            for (int i = 1; i < (num + 1); i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                Console.WriteLine("  El numero " + num + " no es primo.");
            }
            else
            {
                Console.WriteLine("  El numero " + num + " si es primo ");
            }
            
        }
    }
}

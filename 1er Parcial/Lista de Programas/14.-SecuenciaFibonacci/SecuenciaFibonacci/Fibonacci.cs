using System;
using System.Collections.Generic;
using System.Text;

namespace SecuenciaFibonacci
{
    class Fibonacci
    {
        //Atributos de la clase.
        private int x;
        private int v;

        //Constructores
        public Fibonacci() { }
        public Fibonacci(int x)
        {
            this.x = x;
        }

        //Propiedades get y set
        public int X { get => x; set => x = value; }

        public void SecuenciaFibonacci()
        {
            int w = 0;
            int y = 1;
            //v = 0;
            Console.WriteLine("  -- Secuencia");
            Console.WriteLine("");
            for (int i = 0; i < x; i++)
            {
                Console.Write(" ["+ w +"] ");
                v = w + y;
                w = y;
                y = v;
                /* Console.WriteLine(y);
                v = y;
                y += w;
                w = v;
                */
            }
            Console.WriteLine("");
            Console.WriteLine(" ---------------- ");
        }
    }
}

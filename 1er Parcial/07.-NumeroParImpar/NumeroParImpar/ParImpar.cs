using System;
using System.Collections.Generic;
using System.Text;

namespace NumeroParImpar
{
    class ParImpar
    {
        //Atributos de la clase.
        int num;

        //Constructores.
        public ParImpar(){}
        public ParImpar(int num)
        {
            this.num = num;
        }

        //Propiedades GET y SET.
        public int Num { get => num; set => num = value; }

        //Metodos.
        public void NumParImpar()
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(" El numero " + num + " es par");
            }
            else
            {
                Console.WriteLine(" El numero " + num + " es impar");
            }
        }
    }
}

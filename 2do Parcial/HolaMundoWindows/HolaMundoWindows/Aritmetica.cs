using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoWindows
{
    class Aritmetica
    {
        //Atributos de la clase.
        private double num1;
        private double num2;

        //contructores.
        public Aritmetica() { }
        public Aritmetica(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        //Propiedades GET y SET.
        public double Sumar()
        {
            return num1 + num2;
        }
        public double Restar()
        {
            return num1 - num2;
        }
        public double Multiplicar()
        {
            return num1 * num2;
        }
        public double Dividir()
        {
            return num1 / num2;
        }


    }
}

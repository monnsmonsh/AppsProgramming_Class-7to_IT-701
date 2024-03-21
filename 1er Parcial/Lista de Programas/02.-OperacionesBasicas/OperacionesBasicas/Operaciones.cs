using System;
using System.Collections.Generic;
using System.Text;

namespace OperacionesBasicas
{
    class Operaciones
    {
        //Atributos de la clase.
        private double num1;
        private double num2;

        //Constructores
        public Operaciones() { }
        public Operaciones(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        //Propiedades GET y SET.
        public double Num1 { get => num1; set => num1 = value; }
        public double Num2 { get => num2; set => num2 = value; }

        //Metodos.
        public void Sumar()
        {
            double resulSuma = 0;
            resulSuma= num1 + num2;
            Console.WriteLine("La suma de los dos numeros es: " + num1 + " + " + num2 + " = " + resulSuma);
        }
        public void Restar()
        {
            double resulResta = 0;
            resulResta = num1 - num2;
            Console.WriteLine("La resta de los dos numeros es: " + num1 + " - " + num2 + " = " + resulResta);
        }
        public void Multiplicar()
        {
            double resulMulti = 0;
            resulMulti = num1 * num2;
            Console.WriteLine("La multiplicacion de los dos numeros es: " + num1 + " * " + num2 + " = " + resulMulti);
        }
        public void Dividir()
        {
            double resulDividir = 0;
            resulDividir = num1 / num2;
            Console.WriteLine("La divicion de los dos numeros es: " + num1 + " * " + num2 + " = " + resulDividir);
        }
    }
}

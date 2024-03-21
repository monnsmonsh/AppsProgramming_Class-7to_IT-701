using System;
using System.Collections.Generic;
using System.Text;

namespace CalcularHipotenusa
{
    class Ecuacion
    {
        //Atributos de la clase.
        private double a;
        private double b;

        //Constructores.
        public Ecuacion(){} 
        public Ecuacion(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        //Propiedades GET y SET.
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }

        //Metodos.
        public void CalcularHipotenusa()
        {
            double resultado = 0;
            resultado = Math.Sqrt(((a * a) + (b * b)));
            Console.WriteLine("El valor de la hipotenusa es: " + resultado);
        }
    }
}

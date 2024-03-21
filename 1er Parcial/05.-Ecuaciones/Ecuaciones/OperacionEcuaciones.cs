using System;
using System.Collections.Generic;
using System.Text;

namespace Ecuaciones
{
    class OperacionEcuaciones
    {
        //Atributos de la clase.
        private double numA;
        private double numB;

        //Constructor por omision
        public OperacionEcuaciones() { }

        //Constructor definido por el programador
        public OperacionEcuaciones(double numA, double numB)
        {
            this.numA = numA;
            this.numB = numB;
        }

        //Propiedades GET y SET.
        public double NumA { get => numA; set => numA = value; }
        public double NumB { get => numB; set => numB = value; }

        //Metodos.
        public void ResultadoY()
        {
            double resultY = 0;
            resultY = (3 * (Math.Pow(numA, 2))) * (Math.Pow(numB, 2))* (Math.Sqrt(2*numA));
                
            Console.WriteLine("El resultado de Y es: " + resultY);
        }
        public void ResultadoW()
        {
            double resultY = 0;
            resultY = 4* (Math.Sqrt((Math.Pow(2, numA))*(3* (Math.Pow(numA, 2)) * (Math.Pow(numB, 2)) - (Math.Sqrt(2 * numA)))));

            Console.WriteLine("El resultado de Y es: " + resultY);
        }
        public void ResultadoZ()
        {
            double resultY = 0;
            resultY = (12* (Math.Pow(numA, 1/2))) / (Math.Pow(numB, 1 / 4));

            Console.WriteLine("El resultado de Y es: " + resultY);
        }
    }
}

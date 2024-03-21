using System;
using System.Collections.Generic;
using System.Text;

namespace Ecuaciones2doGrado
{
    class OperacionEcuacion2doGrado
    {
        //Atributos de la clase.
        private double numA;
        private double numB;
        private double numC;

        //Constructor por omision
        public OperacionEcuacion2doGrado() { }

        //Constructor definido por el programador
        public OperacionEcuacion2doGrado(double numA, double numB, double numC) {
            this.numA = numA;
            this.numB = numB;
            this.numC = numC;
        }

        //Propiedades GET y SET.
        public double NumA { get => numA; set => numA = value; }
        public double NumB { get => numB; set => numB = value; }
        public double NumC { get => numC; set => numC = value; }

        //Metodos (ecuacion).

        public double X1()
        {
            return (numB + (Math.Sqrt(Math.Pow(numB, 2) - 4*(numA*numC))))/2*numA;
        }
        public double X2()
        {
            return (numB - (Math.Sqrt(Math.Pow(numB, 2) - 4 * (numA * numC)))) / 2 * numA;
        }

    }
}

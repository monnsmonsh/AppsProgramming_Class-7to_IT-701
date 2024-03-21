using System;
using System.Collections.Generic;
using System.Text;

namespace Fraccion
{
    class OperacionFraccion
    {
        //Atributos de la clase.
        private int num1;
        private int den1;
        private int num2;
        private int den2;

        //Constructores
        public OperacionFraccion() { }
        public OperacionFraccion(int num1, int num2, int den1, int den2)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.den1 = den1;
            this.den2 = den2;
        }

        //Propiedades GET y SET.
        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
        public int Den1 { get => den1; set => den1 = value; }
        public int Den2 { get => den2; set => den2 = value; }

        //Metodos.
        public void Suma()
        {
            if (den1 != den2)
            {
                int DenominadorTotal = den1 * den2;
                int NumeradorTotal = (num1 * den2) + (den1 * num2);

                Console.WriteLine("La suma resultante es: " + NumeradorTotal + "/" + DenominadorTotal);
            }
            if (den1 == den2)
            {

                int NumeradorTotal = num2 + num1;

                Console.WriteLine("La suma resultante es: " + NumeradorTotal + "/" + den1);
            }
        }

        public void Resta()
        {
            if (den1 != den2){
                int DenominadorTotal = den1 * den2;
                int NumeradorTotal = (num1 * den2) - (den1 * num2);
                Console.WriteLine("La resta resultante es: " + NumeradorTotal + "/" + DenominadorTotal);
            }
            if (den1 == den2){
                int NumeradorTotal = num1 - num2;
                Console.WriteLine("La resta resultante es: " + NumeradorTotal + "/" + den1);
            }
        }

        public void Multiplicacion(){
            int DenominadorTotal = den1 * den2;
            int NumeradorTotal = num1 * num2;
            Console.WriteLine("La multiplicación resultante es: " + NumeradorTotal + "/" + DenominadorTotal);
        }

        public void Division(){
            int DenominadorTotal = den1 * num2;
            int NumeradorTotal = num1 * den2;
            Console.WriteLine("La División resultante es: " + NumeradorTotal + "/" + DenominadorTotal);
        }

    }
}

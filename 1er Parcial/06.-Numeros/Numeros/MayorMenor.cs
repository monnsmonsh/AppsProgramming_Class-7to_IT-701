using System;
using System.Collections.Generic;
using System.Text;

namespace Numeros
{
    class MayorMenor
    {
        //Atributos de la clase.
        private int num1;
        private int num2;
        private int num3;

        //Constructores
        public MayorMenor() { }
        public MayorMenor(int num1, int num2, int num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }
        //Propiedades GET y SET.
        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
        public int Num3 { get => num3; set => num3 = value; }


        public void NumMayor()
        {
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(" El numero mayor es " + num1);
            }
            else
            {
                if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine(" El numero mayor es " + num2);
                }
                if (num1 == num2 && num1 == num3)
                {
                    
                }
                else
                {
                    Console.WriteLine(" El numero mayor es " + num3);
                }
            }
        }
        public void NumMenor()
        {
            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine(" El numero menor es " + num1);
            }
            else
            {
                if (num2 < num1 && num2 < num3)
                {
                    Console.WriteLine(" El numero menor es " + num2);
                }
                else
                {
                    if (num1 == num2 && num1 == num3)
                    {
                        Console.WriteLine(" Los numeros son iguales ");
                    }
                    else
                    {
                        Console.WriteLine(" El numero menor es " + num3);
                    }
                }

            }
        }
    }
}

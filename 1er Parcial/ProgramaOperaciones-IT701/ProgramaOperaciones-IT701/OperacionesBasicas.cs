using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaOperaciones_IT701
{
    class OperacionesBasicas{
        //Atributos de la clase.
        private double num1;
        private double num2;

        //Propiedades GET y SET.
        public double Num1 { get => num1; set => num1 = value; }
        public double Num2 { get => num2; set => num2 = value; }

        //Metodos.
        public double Sumar(){
            return num1 + num2;
        }
        public double Restar(){
            return num1 - num2;
        }
        public double Multiplicar(){
            return num1 * num2;
        }
        public double Dividir(){
            return num1 / num2;
        }
    }
}

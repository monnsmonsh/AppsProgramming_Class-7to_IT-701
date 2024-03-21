using System;
using System.Collections.Generic;
using System.Text;

namespace Meses
{
    class NumMes
    {
        //Atributos de la clase.
        private int numMes;

        //Constructores
        public NumMes() { }

        public NumMes(int numMes)
        {
            this.numMes = numMes;
        }
        //Propiedades get y set
        public int NumM { get => numMes; set => numMes = value; }

        //Metodos.
        public void Enero()
        {
            Console.WriteLine(" Mes: Enero");
            Console.WriteLine(" Dias: 31");
        }
        public void Febrero()
        {
            Console.WriteLine(" Mes: Febrero");
            Console.WriteLine(" Dias: 28");
        }
        public void Marzo()
        {
            Console.WriteLine(" Mes: Marzo");
            Console.WriteLine(" Dias: 31");
        }
        public void Abril()
        {
            Console.WriteLine(" Mes: Abril");
            Console.WriteLine(" Dias: 30");
        }
        public void Mayo()
        {
            Console.WriteLine(" Mes: Mayo");
            Console.WriteLine(" Dias: 31");
        }
        public void Junio()
        {
            Console.WriteLine(" Mes: Junio");
            Console.WriteLine(" Dias: 30");
        }
        public void Julio()
        {
            Console.WriteLine(" Mes: Julio");
            Console.WriteLine(" Dias: 31");
        }
        public void Agosto()
        {
            Console.WriteLine(" Mes: Agosto");
            Console.WriteLine(" Dias: 30");
        }
        public void Septiembre()
        {
            Console.WriteLine(" Mes: Septiembre");
            Console.WriteLine(" Dias: 31");
        }
        public void Octubre()
        {
            Console.WriteLine(" Mes: Octubre");
            Console.WriteLine(" Dias: 31");
        }
        public void Noviembre()
        {
            Console.WriteLine(" Mes: Noviembre");
            Console.WriteLine(" Dias: 30");
        }
        public void Diciembre()
        {
            Console.WriteLine(" Mes: Diciembre");
            Console.WriteLine(" Dias: 31");
        }
    }
}

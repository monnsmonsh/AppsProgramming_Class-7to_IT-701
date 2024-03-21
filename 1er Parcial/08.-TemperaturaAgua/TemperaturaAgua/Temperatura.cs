using System;
using System.Collections.Generic;
using System.Text;

namespace TemperaturaAgua
{
    class Temperatura
    {
        //Atributos de la clase.
        private double temp;

        //Constructores
        public Temperatura() { }

        public Temperatura(double temp)
        {
            this.temp = temp;
        }
        //Propiedades get y set
        public double Temp { get => temp; set => temp = value; }

        public double X1()
        {
            return (temp + (Math.Sqrt(Math.Pow(temp, 2) - 4)));
        }

        public void EstadoAgua()
        {
            double solido = 0;
            double gas = 100;
            if (temp < solido)
            {
                Console.WriteLine("El estado del agua es Solido");
            }
            else if (temp > gas)
            {
                Console.WriteLine("El estado del agua es Gaseoso");
            }
            else if (temp > solido)
            {
                Console.WriteLine("El estado del agua es Liquido");
            }
        }
    }
}

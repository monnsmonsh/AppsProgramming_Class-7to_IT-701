using System;
using System.Collections.Generic;
using System.Text;

namespace Distancia2Dy3D
{
    class Distancia2D
    {
        //Atributos de la clase.
        private double x;
        private double y;
        

        //Constructor por omision
        public Distancia2D() { }

        //Constructor definido por el programador
        public Distancia2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //Propiedades GET y SET.
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        //Metodos (ecuacion).

        public double ResultadoDistaciaXY(Distancia2D PuntoA)
        {
            return Math.Sqrt(Math.Pow(X-PuntoA.X, 2) + Math.Pow(Y-PuntoA.Y, 2)) ;
        }
    }
}

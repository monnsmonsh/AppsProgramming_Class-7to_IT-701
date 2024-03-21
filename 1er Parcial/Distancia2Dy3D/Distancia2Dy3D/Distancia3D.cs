using System;
using System.Collections.Generic;
using System.Text;

namespace Distancia2Dy3D
{
    class Distancia3D : Distancia2D
    {
        //Atributos de la clase.
        private double z;

        //Constructor por omision
        public Distancia3D() { }

        //Constructor definido por el programador
        public Distancia3D(double x, double y,
            double z)
            : base(x, y)
        {
            this.z = z;
        }

        //Propiedades GET y SET.

        public double Z { get => z; set => z = value; }

       //Metodos (ecuacion).
       public double ResultadoDistaciaXYZ(Distancia3D PuntoA2){
            return Math.Sqrt(Math.Pow(X - PuntoA2.X, 2) + Math.Pow(Y - PuntoA2.Y, 2) + Math.Pow(Z - PuntoA2.Z, 2));
       }
        
    }
}

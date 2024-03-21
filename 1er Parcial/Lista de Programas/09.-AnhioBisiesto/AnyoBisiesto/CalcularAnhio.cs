using System;
using System.Collections.Generic;
using System.Text;

namespace AnyoBisiesto
{
    class CalcularAnhio
    {
        //Atributos de la clase.
        double anhio;
        String validar;
        bool bisiesto = false;

        //Constructores
        public CalcularAnhio(){}
        public CalcularAnhio(double anhio, String validar, bool bisiesto = false)
        {
            this.anhio = anhio;
            this.validar = validar;
            this.bisiesto = bisiesto;
        }

        //Propiedades GET y SET.
        public double Anhio { get => anhio; set => anhio = value; }
        public string Validar { get => validar; set => validar = value; }
        public bool Bisiesto { get => bisiesto; set => bisiesto = value; }
    }
}

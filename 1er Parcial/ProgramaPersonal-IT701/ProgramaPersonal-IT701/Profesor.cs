using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPersonal_IT701
{
    class Profesor : Persona
    {
        //Atributos de Profesor.
        private double pagoHora;
        private int numHoras;

        //Constructor por omision
        public Profesor() { }

        //Constructor definido por el programador
        public Profesor(int clave, string nombre, string direccion, string telefono, string email, DateTime fechaNacimiento,
            double pagoHora, int numHoras)
            : base(clave, nombre, direccion, telefono, email, fechaNacimiento)
        {
            this.pagoHora = pagoHora;
            this.numHoras = numHoras;
        }

        //Propiedades GET y SET
        public double PagoHora { get => pagoHora; set => pagoHora = value; }
        public int NumHoras { get => numHoras; set => numHoras = value; }

        //Metodos
        public double CalcularPagoTotal()
        {
            return pagoHora*numHoras;
        }
    }
}

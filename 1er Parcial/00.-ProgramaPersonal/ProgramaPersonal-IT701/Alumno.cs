using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPersonal_IT701{
    class Alumno : Persona {
        //Atributos del Alumno
        private int calificacion1;
        private int calificacion2;
        private int calificacion3;

        //Constructor por omision
        public Alumno() { }

        //Constructor definido por el programador
        public Alumno(int clave, string nombre, string direccion, string telefono, string email, DateTime fechaNacimiento,
            int calificacion1, int calificacion2, int calificacion3)
            : base(clave, nombre, direccion, telefono, email, fechaNacimiento)
        {
            this.calificacion1 = calificacion1;
            this.calificacion2 = calificacion2;
            this.calificacion3 = calificacion3;
        }

        //Propiedades GET y SET
        public int Calificacion1 { get => calificacion1; set => calificacion1 = value; }
        public int Calificacion2 { get => calificacion2; set => calificacion2 = value; }
        public int Calificacion3 { get => calificacion3; set => calificacion3 = value; }

        //Métodos
        public double CalcularPromedio(){
            return (calificacion1 + calificacion2 + calificacion3) / 3;
        }
    }

}

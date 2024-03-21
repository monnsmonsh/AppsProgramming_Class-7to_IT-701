using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Alumno
    {
        //Atributos de la clase.
        private int matricula;
        private string nombre;
        private string sexo;
        private string fotografia;
        private string direccion;
        private string telefono;
        private string estado;
        private string ciudad;
        private string pasatiempos;
        private int calificacion;

        //Constructores
        public Alumno(){ }
        public Alumno(int matricula, string nombre, string sexo, string fotografia, string direccion, string telefono, string estado, string ciudad, string pasatiempos, int calificacion)
        {
            this.Matricula = matricula;
            this.Nombre = nombre;
            this.Sexo = sexo;
            this.Fotografia = fotografia;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Estado = estado;
            this.Ciudad = ciudad;
            this.Pasatiempos = pasatiempos;
            this.Calificacion = calificacion;
        }
        //Propiedades GET y SET
        public int Matricula { get => matricula; set => matricula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Fotografia { get => fotografia; set => fotografia = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Pasatiempos { get => pasatiempos; set => pasatiempos = value; }
        public int Calificacion { get => calificacion; set => calificacion = value; }

        //Redifinimos el metodo ToString
        public override string ToString()
        {
            return nombre + " - " + calificacion;
        }

        //Metodos


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaPersonal
{
    class Persona
    {
        //Atributos de la clase.
        private int clave;
        private string nombre;
        private string direccion;
        private string telefono;
        private string correo;
        private DateTime fechaNac;

        //Constructor por omision
        public Persona(){}
        //Constructor definido por el programador
        public Persona(int clave, string nombre, string direccion, string telefono, string correo, DateTime fechaNac)
        {
            this.clave = clave;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
            this.fechaNac = fechaNac;
        }

        //Propiedades GET y SET.
        public int Clave { get => clave; set => clave = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }

        //Metodos.
        public int CalcularEdad()
        {
            int anioNac = fechaNac.Year;
            int anioActual = DateTime.Today.Year;
            return anioActual - anioNac;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPersonal_IT701
{
    class Persona{
        //Atributos de la clase
        private int clave;
        private string nombre;
        private string direccion;
        private string telefono;
        private string email;
        private DateTime fechaNacimiento;

        //Constructor por omision
        public Persona() { }

        //Constructor definido por el programador
        public Persona (int clave, string nombre, string direccion, string telefono, string email, DateTime fechaNacimiento)
        {
            this.clave = clave;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
        }

        //Propiedades get y set
        public int Clave { get => clave; set => clave = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaNacimineto { get => fechaNacimiento; set => fechaNacimiento = value; }

        //Métodos
        public int CalcularEdad()
        {
            int anioNac = FechaNacimineto.Year;
            int anioAct = DateTime.Today.Year;
            return anioAct - anioNac;
        }
    }





}

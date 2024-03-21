using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Laboratorista
    {
        //Atributos de la Clase.
        private int numEmpleado;
        private string nombre;
        private string apellido;
        private string correo;
        private string turno;
        private string password;

        //Constructores
        public Laboratorista(int numEmpleado, string nombre, string apellido, string correo, string turno, string password)
        {
            this.numEmpleado = numEmpleado;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.turno = turno;
            this.password = password;
        }
        public Laboratorista(string nombre, string apellido, string correo, string turno, string password)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.turno = turno;
            this.password = password;
        }

        //Metodos GET y SET
        public int NumEmpleado { get => numEmpleado; set => numEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Turno { get => turno; set => turno = value; }
        public string Password { get => password; set => password = value; }

        //Metodos
        public override string ToString()
        {
            return nombre;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente
    {
        //Atributos de la Clase.
        private int idCliente;
        private string rfc;
        private string nombre;
        private string direccion;
        private string colonia;

        //Constructores
        public Cliente(int idCliente, string rfc, string nombre, string direccion, string colonia)
        {
            this.idCliente = idCliente;
            this.rfc = rfc;
            this.nombre = nombre;
            this.direccion = direccion;
            this.colonia = colonia;
        }
        public Cliente(string rfc, string nombre, string direccion, string colonia)
        {
            this.rfc = rfc;
            this.nombre = nombre;
            this.direccion = direccion;
            this.colonia = colonia;
        }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Rfc { get => rfc; set => rfc = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Colonia { get => colonia; set => colonia = value; }

        //Metodos
        public override string ToString()
        {
            return nombre;
        }



    }
}

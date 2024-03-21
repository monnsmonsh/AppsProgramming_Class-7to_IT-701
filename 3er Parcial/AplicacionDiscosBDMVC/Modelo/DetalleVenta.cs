using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DetalleVenta
    {
        //Atributos de la Clase.
        private int numVenta;
        private int idDisco;
        private int cantidad;
        private double precio;

        //Constructores
        public DetalleVenta() { }
        public DetalleVenta(int numVenta, int idDisco, int cantidad, double precio)
        {
            this.numVenta = numVenta;
            this.idDisco = idDisco;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public int NumVenta { get => numVenta; set => numVenta = value; }
        public int IdDisco { get => idDisco; set => idDisco = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }

    }
}

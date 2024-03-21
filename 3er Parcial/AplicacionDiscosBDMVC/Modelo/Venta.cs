using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Venta
    {
        //Atributos de la Clase.
        private string numVenta;
        private DateTime fecha;
        private int idCliente;
        private string observaciones;
        private List<DetalleVenta> lstDiscos;

        //Constructores
        public Venta() { }
        public Venta(string numVenta, DateTime fecha, int idCliente, string observaciones, List<DetalleVenta> lstDiscos)
        {
            this.NumVenta = numVenta;
            this.Fecha = fecha;
            this.IdCliente = idCliente;
            this.Observaciones = observaciones;
            this.LstDiscos = lstDiscos;
        }

        //Metodos GET y SET.
        public string NumVenta { get => numVenta; set => numVenta = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public List<DetalleVenta> LstDiscos { get => lstDiscos; set => lstDiscos = value; }

        //Método de la clase que sirve para agregar un nuevo objeto DetalleVenta a la lista de discos.
        public void AgregarDetalle(DetalleVenta objDetalleVenta)
        {
            lstDiscos.Add(objDetalleVenta);
        }

        //Método de la clase que calcula el subtotal de la venta segun los productos y cantidades agregados.
        public double calcularSubTotal()
        {
            double subTotal = 0;
            foreach (DetalleVenta objDetalle in lstDiscos)
            {
                subTotal += (objDetalle.Cantidad * objDetalle.Precio);
            }
            return subTotal;

        }
    }
}

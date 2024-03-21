using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using MySql.Data.MySqlClient;

namespace Controlador
{
    public class VentaMgr
    {
        MySQLConnection objMySqlBD = null;
        Venta objVenta = null;

        public VentaMgr() { }
        public VentaMgr(Venta objVenta)
        {
            this.objVenta = objVenta;
        }

        /*Método para consultar las ventas de la Base de Datos*/
        public DataSet ConsultarVentas()
        {
            //Creamos un objeto de la clase MySQLConnection para manejar la comunicacidén con la BD.
            objMySqlBD = new MySQLConnection();
            try
            {
                //Intentamos conectarnos a la BD.
                if (!objMySqlBD.conectar())
                    return null;

                //Definimos la consulta a ejecutar.
                string sql = "SELECT numVenta, fecha, nombre," +
                    " subtotal,iva,total FROM ventas as V INNER JOIN cliente as C on " +
                    "(V.idCliente = C.idCliente) ORDER BY numVenta DESC;";

                //Enviamos a ejecutar la consulta y recuperamos el DataSet.
                DataSet dsVentas = objMySqlBD.obtenerDatos(sql);

                //Cerramos la conexidn.
                objMySqlBD.cerrarConexion();
                return dsVentas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        

        /*Método que permite consultar el detalle venta para una venta en especifica*/
		public DataSet ConsultarDetalleVenta(string numVenta)
		{
			//Creamos un objeto de la clase MySQLConnection para manejar la comunicacidén con la BD.
			objMySqlBD = new MySQLConnection();
			try
			{
                //Intentamos conectarnos a la BD.
                if (!objMySqlBD.conectar())
                    return null;
                //Definimos la consulta a ejecutar.
                string sql = "SELECT V.numVenta,titulo,cantidad,DV.precio " +
                "FROM ventas as V INNER JOIN detalleventa as DV ON (V.numVenta = DV.numVenta) INNER JOIN Disco as D ON (DV.idDisco = D.idDisco) " +
 "WHERE V.numVenta = '" + numVenta + "';";
                //Enviamos a ejecutar la consulta y recuperamos el DataSet.
                DataSet dsDetalleVenta = objMySqlBD.obtenerDatos(sql);
                //Cerramos la conexión.
                objMySqlBD.cerrarConexion();
                return dsDetalleVenta;

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
		}




        public bool InsertarVenta()
        {
            //Creamos un objeto de la clase MySQLConnection para manejar la comunicacién con la BD.
            objMySqlBD = new MySQLConnection();
            ArrayList sql = new ArrayList();
            bool result;
            try
            {
                if (!objMySqlBD.conectar())
                    result = false;

                string fechal = objVenta.Fecha.Year + "-" +
                    objVenta.Fecha.Month + "-" + objVenta.Fecha.Day;
                double subtotal = objVenta.calcularSubTotal();

                //Definimos la consulta a ejecutar.
                sql.Add("INSERT INTO Ventas VALUES('" + objVenta.NumVenta + "','" + fechal + "'," +
                objVenta.IdCliente + ",'" + objVenta.Observaciones + "','" +
                subtotal + "','" + subtotal * 0.16 + "','" + subtotal * 1.16 + "'); ");

                //Recuperamos la lista con el detalle de la venta.
                List<DetalleVenta> lstDetalleVenta = objVenta.LstDiscos;
                foreach (DetalleVenta objDetalleVenta in lstDetalleVenta)
                {
                    sql.Add("INSERT INTO DetalleVenta VALUES('" + objVenta.NumVenta + "'," +objDetalleVenta.IdDisco +
                    "," + objDetalleVenta.Cantidad + ", '" + objDetalleVenta.Precio + "'); ");
                }

                //Enviamos a ejecutar la consulta y confirmamos el resultado.
                result = objMySqlBD.ejecutarTransaccion(sql);
                objMySqlBD.cerrarConexion();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}

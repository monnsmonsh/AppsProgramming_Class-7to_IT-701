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
    public class ClienteMgr
    {
        MySQLConnection objMySqlBD = null;
        Cliente objCliente = null;
        public ClienteMgr() { }
        public ClienteMgr(Cliente objCliente)
        {
            this.objCliente = objCliente;
        }

        /***Método para consultar todos los Clientes de la Base de Datos***/
        public DataSet ConsultarClientes()
        {
            //Creamos un objeto de la clase MySQLConnection para manejar la comunicacidén con la BD.
            objMySqlBD = new MySQLConnection();
            try
            {
                //Intentamos conectarnos a la BD.
                if (!objMySqlBD.conectar())
                    return null;
                //Definimos la consulta a ejecutar.
                string sql = "SELECT* FROM cliente; ";
                //Enviamos a ejecutar la consulta y recuperamos el DataSet.
                DataSet dsClientes = objMySqlBD.obtenerDatos(sql);
                //Cerramos la conexion.
                objMySqlBD.cerrarConexion();
                return dsClientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }



        /***Método para consultar todos los Clientes de la Base de Datos***/
        public List<Cliente> ObtenerClientesList()

        {

            //Creamos un objeto de la clase MySQLConnection para manejar la comunicacidén con la BD.
            objMySqlBD = new MySQLConnection();
            List<Cliente> lstClientes = new List<Cliente>();
            try
            {
                //Intentamos conectarnos a la BD.
                if (!objMySqlBD.conectar())
                    return null;
                //Definimos la consulta a ejecutar.
                string sql = "SELECT* FROM cliente;";
                //Enviamos a ejecutar la consulta y recuperamos con un DataReader.
                MySqlDataReader drClientes = objMySqlBD.obtenerDatosDataReader(sql);

                //Recorremos el DataReader y agregamos los registros a la Lista.
                while (drClientes.Read())
                {

                    Cliente objCliente = new Cliente(drClientes.GetInt32("idCliente"),
                    drClientes.GetString("rfc"),
                    drClientes.GetString("nombre"),
                    drClientes.GetString("direccion"),
                    drClientes.GetString("colonia"));

                    lstClientes.Add(objCliente);
                }
                //Cerramos la conexion.
                objMySqlBD.cerrarConexion();
                return lstClientes;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }



        /***Método para insertar un nuevo cliente en la Base de Datos***/
        public bool InsertarCliente()
        {
            //Creamos un objeto de la clase MySQLConnection para manejar la comunicacion con la BD.
            objMySqlBD = new MySQLConnection();
            ArrayList sql = new ArrayList();
            bool result;
            try
            {
                if (!objMySqlBD.conectar())
                    result = false;

                //Definimos la consulta a ejecutar.
                sql.Add("INSERT INTO Cliente VALUES(null,'" + objCliente.Rfc + "','" +
                    objCliente.Nombre + "', '" + objCliente.Direccion + "', '" +
                    objCliente.Colonia + "');");


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

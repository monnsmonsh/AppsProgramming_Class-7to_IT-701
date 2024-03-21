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
    public class DiscoMgr
    {
        MySQLConnection objMySqlBD = null;
        Disco objDisco = null;

        public DiscoMgr() { }
        public DiscoMgr(Disco objDisco)
        {
            this.objDisco = objDisco;
        }


        /***Método para consultar todos los Discos de la Tabla de Disco***/
        public DataSet ConsultarDiscos()
        {
            //Creamos un objeto de la clase MySQLConnection para manejar la comunicaci6én con la BD.
            objMySqlBD = new MySQLConnection();
            try
            {
                //Intentamos conectarnos a la BD.
                if (!objMySqlBD.conectar())
                    return null;
                //Definimos la consulta a ejecutar.
                string sql = "SELECT * FROM disco;";
                //Enviamos a ejecutar la consulta y recuperamos el DataSet.
                DataSet dsDiscos = objMySqlBD.obtenerDatos(sql);
                //Cerramos la conexidon.
                objMySqlBD.cerrarConexion();
                return dsDiscos;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }



        /***Método para consultar todos los Discos de la Tabla de Disco***/
        public List<Disco> ObtenerDiscosList()
        {
            //Creamos un objeto de la clase MySQLConnection para manejar la comunicacidén con la BD.
            objMySqlBD = new MySQLConnection();
            List<Disco> lstDiscos = new List<Disco>();

            try
            {
                //Intentamos conectarnos a la BD.
                if (!objMySqlBD.conectar())
                    return null;
                //Definimos la consulta a ejecutar.
                string sql = "SELECT* FROM disco;";
                //Enviamos a ejecutar la consulta y recuperamos con un DataReader.
                MySqlDataReader drDiscos = objMySqlBD.obtenerDatosDataReader(sql);

                //Recorremos el DataReader y agregamos los registros a la Lista.
                while (drDiscos.Read())
                {
                    Disco objDisco = new Disco(drDiscos.GetInt32("idDisco"),
                        drDiscos.GetString("titulo"),
                        drDiscos.GetString("artista"),
                        drDiscos.GetInt32("numPistas"),
                        drDiscos.GetDateTime("fechaLanzamiento"),
                        drDiscos.GetDouble("precio"));

                    lstDiscos.Add(objDisco);
                }
                //Cerramos la conexidn.
                objMySqlBD.cerrarConexion();
                return lstDiscos;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }



        /***Método para insertar un nuevo Disco en la Tabla de Disco***/
        public bool InsertarDisco()
        {
            //Creamos un objeto de la clase MySQLConnection para manejar la comunicacién con la BD.
            objMySqlBD = new MySQLConnection();
            ArrayList sql = new ArrayList();
            bool result;
            try
            {
                if (!objMySqlBD.conectar())
                    result = false;
                string fechaL = objDisco.FechaLanzamiento.Year + "-" +
                    objDisco.FechaLanzamiento.Month + "-" + objDisco.FechaLanzamiento.Day;
                //Definimos la consulta a ejecutar.
                sql.Add("INSERT INTO Disco VALUES(null,'" + objDisco.Titulo + "','" +
                    objDisco.Artista + "'," + objDisco.NumPistas + ",'" +
                    fechaL + "',"  + objDisco.Precio + ");");

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



        /***Método para eliminar un Disco en la Tabla de Disco***/
        public bool EliminarDisco(int idDisco)
        {
            //Creamos un objeto de la clase MySQLConnection para manejar la comunicacidén con la BD.
            objMySqlBD = new MySQLConnection();
            ArrayList sql = new ArrayList();
            bool result;
            try
            {
                if (!objMySqlBD.conectar())
                    result = false;
                //Definimos la consulta a ejecutar.
                sql.Add("DELETE FROM disco WHERE idDisco = " + idDisco + ";");

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



        /***Metodo para actualizar un Disco en la Tabla de Disco***/
        public bool ActualizarDisco()
        {
            //Creamos un objeto de la clase MySQLConnection para manejar la comunicacion con la BD.
            objMySqlBD = new MySQLConnection();
            ArrayList sql = new ArrayList();
            bool result;

            try
            {
                if (!objMySqlBD.conectar())
                    result = false;
                string fechaL = objDisco.FechaLanzamiento.Year + "-" +
                objDisco.FechaLanzamiento.Month + "-" + objDisco.FechaLanzamiento.Day;

                //Definimos la consulta a ejecutar.
                sql.Add("UPDATE disco SET titulo = '" + objDisco.Titulo + 
                    "',artista = '" + objDisco.Artista + 
                    "',numPistas = " + objDisco.NumPistas +
                    ",fechaLanzamiento = '" + fechaL + 
                    "',precio = " + objDisco.Precio +
                    " WHERE idDisco = " + objDisco.IdDisco + ";");


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





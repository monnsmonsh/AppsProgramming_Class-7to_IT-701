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
    public class LaboratoristaMgr
    {
        MySQLConnection objMySqlBD = null;
        Laboratorista objLaboratorista = null;
        public LaboratoristaMgr() { }
        public LaboratoristaMgr(Laboratorista objLaboratorista)
        {
            this.objLaboratorista = objLaboratorista;
        }

        /***Método para consultar todos los Laboratoristas de la Base de Datos***/
        public DataSet ConsultarLaboratorista()
        {
            //Creamos un objeto de la clase MySQLConnection para manejar la comunicacidén con la BD.
            objMySqlBD = new MySQLConnection();
            try
            {
                //Intentamos conectarnos a la BD.
                if (!objMySqlBD.conectar())
                    return null;
                //Definimos la consulta a ejecutar.
                string sql = "SELECT* FROM laboratorista; ";
                //Enviamos a ejecutar la consulta y recuperamos el DataSet.
                DataSet dsLaboratorista = objMySqlBD.obtenerDatos(sql);
                //Cerramos la conexion.
                objMySqlBD.cerrarConexion();
                return dsLaboratorista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /***Método para consultar todos los Laboratorista de la Base de Datos***/
        public List<Laboratorista> ObtenerLaboratoristaList()
        {
            //Creamos un objeto de la clase MySQLConnection para manejar la comunicacidén con la BD.
            objMySqlBD = new MySQLConnection();
            List<Laboratorista> lstLaboratorista = new List<Laboratorista>();
            try
            {
                //Intentamos conectarnos a la BD.
                if (!objMySqlBD.conectar())
                    return null;
                //Definimos la consulta a ejecutar.
                string sql = "SELECT* FROM laboratorista;";
                //Enviamos a ejecutar la consulta y recuperamos con un DataReader.
                MySqlDataReader drLaboratorista = objMySqlBD.obtenerDatosDataReader(sql);

                //Recorremos el DataReader y agregamos los registros a la Lista.
                while (drLaboratorista.Read())
                {
                    Laboratorista objLaboratorista = new Laboratorista(drLaboratorista.GetInt32("numEmpleado"),
                        drLaboratorista.GetString("nombre"),
                        drLaboratorista.GetString("apellidos"),
                        drLaboratorista.GetString("correo"),
                        drLaboratorista.GetString("turno"),
                        drLaboratorista.GetString("password"));

                    lstLaboratorista.Add(objLaboratorista);
                }
                //Cerramos la conexion.
                objMySqlBD.cerrarConexion();
                return lstLaboratorista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /***Método para insertar un nuevo Laboratorista en la Base de Datos***/
        public bool InsertarLaboratorista()
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
                sql.Add("INSERT INTO Laboratorista VALUES(null,'" + objLaboratorista.Nombre + "','" +
                    objLaboratorista.Apellido + "', '" + objLaboratorista.Correo + "', '" +
                    objLaboratorista.Turno + "', '" + objLaboratorista.Password + "');");

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
        public bool EliminarLaboratorista(int numEmpleado)
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
                sql.Add("DELETE FROM laboratorista WHERE numEmpleado = " + numEmpleado + ";");

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
        public bool ActualizarLaboratorista()
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
                sql.Add("UPDATE laboratorista SET nombre = '" + objLaboratorista.Nombre +
                    "', apellidos = '" + objLaboratorista.Apellido +
                    "', correo = '" + objLaboratorista.Correo +
                    "', turno = '" + objLaboratorista.Turno +
                    "', password = '" + objLaboratorista.Password +
                    "' WHERE numEmpleado = " + objLaboratorista.NumEmpleado +";");

          

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

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class MySQLConnection
    {
        //Objeto MySqlConnection que representa la conexión con el servidor de Bases de Datos.
        MySqlConnection MySqlConexion = null;
        //Objeto SqlCommand que contiene las consultas a enviar al servidor de Bases de Datos.
        MySqlCommand MySqlCommand = null;
        //Objeto SqlTransaction encargado de manejar la tansacción en la base de datos.
        MySqlTransaction MySqlTransaction = null;
        //Objeto DataSet encargado de manejar el conjunto de resultados.
        DataSet dsRegistros = null;

        /**
         * Método que establece una conexión con el Servidor de Base de Datos MySQL.
         */
        public bool conectar()
        {
            try
            {
                //Si ya está conectado a la BD.
                if (MySqlConexion != null)
                    return true;

                //Abrimos una nueva conexión.
                string conectionString = "server=localhost;user=root;database=Laboratoriosbd;port=3306;password=";
                MySqlConexion = new MySqlConnection(conectionString);
                MySqlConexion.Open();
                //sqlConexion.State = ConnectionState.Open;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de conexión con la Base de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MySqlConexion = null;
                return false;
            }
        }

        /**
         * Método que establece una conexión con el Servidor de Base de Datos MySQL pasandole la cadena
         * de Conexión.
         * @param conectionString - Cadena de conexión a utilizar.
         */
        public bool conectar(string conectionString)
        {
            try
            {
                //Si ya está conectado a la BD.
                if (MySqlConexion != null)
                    return true;

                //Abrimos una nueva conexión.
                MySqlConexion = new MySqlConnection(conectionString);
                MySqlConexion.Open();
                //sqlConexion.State = ConnectionState.Open;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de conexión con la Base de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MySqlConexion = null;
                return false;
            }
        }

        /**
         * Método que cierra adecuadamente la conexión con la Base de Datos y los
         * objetos que trabajan con ella.
         */
        public void cerrarConexion()
        {
            try
            {
                if (MySqlConexion != null)
                    MySqlConexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cerrar la conexión con la Base de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * Método que envia un conjunto de consultas de modificación (INSERT, UPDATE AND DELETE) al servidor
         * de Base de Datos y las ejecuta como una única transacción.
         * @param sql - Arreglo de caracteres con la(s) consulta(s) SQL a ejecutarse en la transacción.
         * @return - Retorna un valor booleano que indica si la transacción tuvo éxito o no.
         */
        public bool ejecutarTransaccion(ArrayList sql)
        {
            //Iniciamos una transacción local.
            MySqlTransaction = MySqlConexion.BeginTransaction(IsolationLevel.ReadCommitted);
            MySqlCommand = MySqlConexion.CreateCommand();
            bool result = false;

            try
            {
                //Enviamos a ejecutar cada una de las consultas de la transaccion.
                for (int i = 0; i < sql.Count; i++)
                {
                    MySqlCommand.CommandText = (string)sql[i];
                    MySqlCommand.ExecuteNonQuery();
                }

                MySqlTransaction.Commit();
                result = true;
            }
            catch (Exception ex)
            {
                MySqlTransaction.Rollback();
                MessageBox.Show(ex.Message, "Error al Ejecutar la Transacción.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            finally
            {
                MySqlCommand.Dispose();
                MySqlTransaction.Dispose();
            }
            return result;
        }

        /**
         * Método que envia y ejecuta una consulta SELECT al servidor y retorna un objeto DataSet
         * con el conjunto de resultados.
         * @param sql - Cadena de caracteres con la consulta en SQL.
         * @return - Objeto DataSet con el conjunto de resultados.
         */
        public DataSet obtenerDatos(string sql)
        {
            MySqlDataAdapter dataAdapter = null;
            dsRegistros = new DataSet();

            try
            {
                MySqlCommand = new MySqlCommand(sql, MySqlConexion);
                dataAdapter = new MySqlDataAdapter(MySqlCommand);
                dataAdapter.Fill(dsRegistros, "Resultado");
                return dsRegistros;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al obtener datos la Base de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /**
         * Método que envia y ejecuta una consulta SELECT al servidor y retorna un objeto MySqlDataReader
         * con el conjunto de resultados.
         * @param sql - Cadena de caracteres con la consulta en SQL.
         * @return - Objeto DataReader con el conjunto de resultados.
         */
        public MySqlDataReader obtenerDatosDataReader(string sql)
        {
            try
            {
                MySqlCommand = new MySqlCommand(sql, MySqlConexion);
                MySqlDataReader dataReader = MySqlCommand.ExecuteReader();
                return dataReader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al obtener datos la Base de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}


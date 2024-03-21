using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Controlador;
using Modelo;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void cargarDatos()
        {
            //Creamos un objeto de la clase Controlador.
            DiscoMgr objDiscoMgr = new DiscoMgr();
            try
            {
                //Creamos un objeto DataSet para almacenar el conjunto de datos de Discos.
                DataSet dsDiscos = objDiscoMgr.ConsultarDiscos();
                //Asignamos el DataSet al DataGridView.
                dgvDiscos.DataSource = dsDiscos;
                dgvDiscos.DataMember = "Resultado";
                //Establecemos los encabezadso a las columnas del DataGridView
                dgvDiscos.Columns[0].HeaderText = "ID Disco";
                dgvDiscos.Columns[1].HeaderText = "Titulo";
                dgvDiscos.Columns[2].HeaderText = "Artista";
                dgvDiscos.Columns[3].HeaderText = "Num.Pistas";
                dgvDiscos.Columns[4].HeaderText = "Fecha de Lanzamiento";
                dgvDiscos.Columns[5].HeaderText = "Precio";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Base de Datos");
            }
        }
        private void limpiarCampos()
        {
            lblIdDiscoVal.Text = "-----------";
            txtTitulo.Text = "";
            txtArtista.Text = "";
            spnNumPistas.Value = 0;
            dtpFechaL.Value = DateTime.Today;
            txtPrecio.Text = "";

        }
        private void Form_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text == "Cancelar")
            { 
                limpiarCampos();
                btnGuardar.Text = "Guardar";
                btnActualizar.Enabled = false;
                return;
            }

            //Recuperamos los datos del formulario.
            string titulo = txtTitulo.Text;
            string artista = txtArtista.Text;
            int numPistas = (int)spnNumPistas.Value;
            string fechaL = dtpFechaL.Value.Year + "-" +
            dtpFechaL.Value.Month + "-" + dtpFechaL.Value.Day;
            double precio = Convert.ToDouble(txtPrecio.Text);
            //Creamos un nuevo objeto de la clase Disco.
            Disco objDisco = new Disco(titulo, artista, numPistas, Convert.ToDateTime(fechaL), precio);

            try
            {
                //Creamos un objeto de la clase Controlador.
                DiscoMgr objDiscoMgr = new DiscoMgr(objDisco);
                //Mandamos a Guardar el nuevo Disco a la BD.
                if (objDiscoMgr.InsertarDisco())

                    MessageBox.Show(this, "El Disco se Guard6 Correctamente", "Catalogo de Discos MVC",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargarDatos();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error al Guardar el Disco",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



    }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvDiscos.SelectedRows.Count == 0)
                return;

            DialogResult botonRespuesta = MessageBox.Show(this, "Estas seguro de eliminar el disco ? ",
            "Catalogo Discos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ;
            if (botonRespuesta == DialogResult.No)
                return;

            //Recuperamos el id del Disco seleccionado.
            int idDisco = Convert.ToInt32(dgvDiscos.SelectedRows[0].Cells[0].Value);

            try
            {
                //Creamos un objeto de la clase Controlador.
                DiscoMgr objDiscoMgr = new DiscoMgr();
                //Mandamos a eliminar el disco seleccionado en la tabla.
                if (objDiscoMgr.EliminarDisco(idDisco))
                {
                    MessageBox.Show(this, "El Disco con id " + idDisco + " se Eliminé Correctamente",
                    "Catalogo de Discos", MessageBoxButtons.OK, MessageBoxIcon. Information) ;
                    cargarDatos();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Error al Eliminar el Disco",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvDiscos_DoubleClick(object sender, EventArgs e)
        {
            //Obtenemos el Indice de la fila seleccionada
            int f = dgvDiscos.CurrentCellAddress.Y;

            //Recuperamos los valores del DataGrid y los pasamos a los campos del formulario.
            lblIdDiscoVal.Text = Convert.ToString(Convert.ToInt32(dgvDiscos.Rows[f].Cells[0].Value));
            txtTitulo.Text = Convert.ToString(dgvDiscos.Rows[f].Cells[1].Value);
            txtArtista.Text = Convert.ToString(dgvDiscos.Rows[f].Cells[2].Value);
            spnNumPistas.Value = Convert.ToDecimal(Convert.ToInt32(dgvDiscos.Rows[f].Cells[3].Value));
            dtpFechaL.Value = Convert.ToDateTime(dgvDiscos.Rows[f].Cells[4].Value);
            txtPrecio.Text = Convert.ToString(Convert.ToDouble(dgvDiscos.Rows[f].Cells[5].Value));

            //Habilitamos el boton Actualizar.
            btnActualizar.Enabled = true;

            //Cambiamos el Texto del botoén Guardar por Cancelar.
            btnGuardar.Text = "Cancelar";


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Recuperamos los datos del formulario.
            int idDisco = Convert.ToInt16(lblIdDiscoVal.Text);
            string titulo = txtTitulo.Text;
            string artista = txtArtista.Text;
            int numPistas = (int)spnNumPistas.Value;
            string fechaL = dtpFechaL.Value.Year + "-" +
                dtpFechaL.Value.Month + "-" + dtpFechaL.Value.Day;
            double precio = Convert.ToDouble(txtPrecio.Text);

            //Creamos un nuevo objeto de la clase Disco.
            Disco objDisco = new Disco(idDisco, titulo, artista, numPistas,
                Convert.ToDateTime(fechaL), precio);

            try
            {
                //Creamos un objeto de la clase Controlador.
                DiscoMgr objDiscoMgr = new DiscoMgr(objDisco);

                //Mandamos a Actualizar los datos del Disco a la BD.
                if (objDiscoMgr.ActualizarDisco())
                {
                    MessageBox.Show(this, "El Disco se Actualiz6 Correctamente", "Catalogo de Discos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatos();
                    limpiarCampos();
                    //Reestablecemos los botones Guardar y Actualizar
                    btnGuardar.Text = "Guardar";
                    btnActualizar.Enabled = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error al Actualizar el Disco",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

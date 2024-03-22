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

namespace PruevaLaboratoristas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void cargarDatosLaboratorista()
        {
            //Creamos un objeto de la clase Controlador.
            LaboratoristaMgr objLaboratoristaMgr = new LaboratoristaMgr();
            try
            {
                //Creamos un objeto DataSet para almacenar el conjunto de datos de Discos.
                DataSet dsLaboratorista = objLaboratoristaMgr.ConsultarLaboratorista();
                //Asignamos el DataSet al DataGridView.
                dgvLaboratorista.DataSource = dsLaboratorista;
                dgvLaboratorista.DataMember = "Resultado";
                //Establecemos los encabezadso a las columnas del DataGridView
                dgvLaboratorista.Columns[0].HeaderText = "numEmpleado";
                dgvLaboratorista.Columns[1].HeaderText = "Nombre";
                dgvLaboratorista.Columns[2].HeaderText = "Apellidos";
                dgvLaboratorista.Columns[3].HeaderText = "Correo";
                dgvLaboratorista.Columns[4].HeaderText = "Turno";
                dgvLaboratorista.Columns[5].HeaderText = "Password";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Base de Datos");
            }
        }

        private void limpiarCamposLaboratorista()
        {
            lblIdLaboratorista.Text = "-----------";
            lblIdLaboratorio.Text = "-----------";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtTurno.Text = "";
            txtPassword.Text = "";

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text == "Cancelar")
            {
                limpiarCamposLaboratorista();
                btnGuardar.Text = "Guardar";
                btnActualizar.Enabled = false;
                return;
            }

            //Recuperamos los datos del formulario.
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtCorreo.Text;
            string turno = txtTurno.Text;
            string password = txtPassword.Text;

            //Creamos un nuevo objeto de la clase Disco.
            Laboratorista objLaboratorista = new Laboratorista(nombre, apellido, correo, turno, password);

            try
            {
                //Creamos un objeto de la clase Controlador.
                LaboratoristaMgr objLaboratoristaMgr = new LaboratoristaMgr(objLaboratorista);
                //Mandamos a Guardar el nuevo Disco a la BD.
                if (objLaboratoristaMgr.InsertarLaboratorista())

                    MessageBox.Show(this, "El Laboratorista se Guardo Correctamente", "Catalogo de Laboratorista MVC",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargarDatosLaboratorista();
                limpiarCamposLaboratorista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error al Guardar el Disco",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvLaboratorista.SelectedRows.Count == 0)
                return;

            DialogResult botonRespuesta = MessageBox.Show(this, "Estas seguro de eliminar el disco ? ",
            "Catalogo Discos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (botonRespuesta == DialogResult.No)
                return;

            //Recuperamos el id del Disco seleccionado.
            int numEmpleado = Convert.ToInt32(dgvLaboratorista.SelectedRows[0].Cells[0].Value);

            try
            {
                //Creamos un objeto de la clase Controlador.
                LaboratoristaMgr objDiscoMgr = new LaboratoristaMgr();
                //Mandamos a eliminar el disco seleccionado en la tabla.
                if (objDiscoMgr.EliminarLaboratorista(numEmpleado))
                {
                    MessageBox.Show(this, "El Disco con id " + numEmpleado + " se Eliminé Correctamente",
                    "Catalogo de Discos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatosLaboratorista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error al Eliminar el Disco",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvLaboratorista_Click(object sender, EventArgs e)
        {
            //Obtenemos el Indice de la fila seleccionada
            int f = dgvLaboratorista.CurrentCellAddress.Y;

            //Recuperamos los valores del DataGrid y los pasamos a los campos del formulario.
            lblIdLaboratorista.Text = Convert.ToString(Convert.ToInt32(dgvLaboratorista.Rows[f].Cells[0].Value));
            txtNombre.Text = Convert.ToString(dgvLaboratorista.Rows[f].Cells[1].Value);
            txtApellido.Text = Convert.ToString(dgvLaboratorista.Rows[f].Cells[2].Value);
            txtCorreo.Text = Convert.ToString(dgvLaboratorista.Rows[f].Cells[3].Value);
            txtTurno.Text = Convert.ToString(dgvLaboratorista.Rows[f].Cells[4].Value);
            txtPassword.Text = Convert.ToString(dgvLaboratorista.Rows[f].Cells[5].Value);

            //Habilitamos el boton Actualizar.
            btnActualizar.Enabled = true;

            //Cambiamos el Texto del botoén Guardar por Cancelar.
            btnGuardar.Text = "Cancelar";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Recuperamos los datos del formulario.
            int numEmpleado = Convert.ToInt16(lblIdLaboratorista.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtCorreo.Text;
            string turno = txtTurno.Text;
            string password = txtPassword.Text;

            //Creamos un nuevo objeto de la clase Disco.
            Laboratorista objLaboratorista = new Laboratorista(numEmpleado, nombre, apellido, correo, turno, password);

            try
            {
                //Creamos un objeto de la clase Controlador.
                LaboratoristaMgr objLaboratoristaMgr = new LaboratoristaMgr(objLaboratorista);

                //Mandamos a Actualizar los datos del Disco a la BD.
                if (objLaboratoristaMgr.ActualizarLaboratorista())
                {
                    MessageBox.Show(this, "El Laboratorista se Actualizado Correctamente", "Catalogo de Laboratorista",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatosLaboratorista();
                    limpiarCamposLaboratorista();
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







        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}

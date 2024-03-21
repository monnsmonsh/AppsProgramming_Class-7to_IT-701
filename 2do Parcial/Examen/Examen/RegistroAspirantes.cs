using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class RegistroAspirantes : Form
    {
        private Alumno objAlumno;
        string ruta = "";
        public RegistroAspirantes()
        {
            InitializeComponent();
        }

        private void RegistroAspirantes_Load(object sender, EventArgs e)
        {
        }
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "*.bmp;*.jpg;*.png|*bmp;*.jpg;*.png;";
            abrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            abrir.Title = "Selecciona la foto del estudiante.";
            abrir.RestoreDirectory = true;

            try
            {
                if (abrir.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(abrir.FileName);
                    ruta=abrir.FileName;
                }
            }
            catch
            {
                MessageBox.Show("No se selecciono ninguna fotografía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //********* Extraemos los datos del formulario *********//
            int matricula = Int32.Parse(txtMatricula.Text);
            string nombre = txtNombre.Text;
            /*string texto*/
            string sexo = "";
            if (rbtFemenino.Checked)
               sexo = "Femenino";
            else if (rbtMasculino.Checked)
                sexo = "Masculino";
            /*--------*/
            string fotofrafia = ruta;
            string dirrecion = txtDirreccion.Text;
            string telefono = txtTelefono.Text;
            string estado= cboEstados.Text;
            string ciudad= txtCiudad.Text;
            string pasatiempos="";
            /*pasatiempos*/
            if (chkLeer.Checked == true)
                pasatiempos = pasatiempos + "Leer, ";
            if (chkDeporte.Checked == true)
                pasatiempos = pasatiempos + " Hacer deporte, ";
            if (chkPeliculas.Checked == true)
                pasatiempos = pasatiempos + " ver peliculas, ";
            if (chkMusica.Checked == true)
                pasatiempos = pasatiempos + " escuchar musica, ";
            if (chkAmigos.Checked == true)
                pasatiempos = pasatiempos + " salir con amigos, ";
            if (chkViajar.Checked == true)
                pasatiempos = pasatiempos + " viajar ";
            /* --------- */


            int calificacion = 0;


            //Creamos un nuevo objeto de la clase Disco
            Alumno objAlumno = new Alumno(matricula, nombre, sexo, fotofrafia, dirrecion, telefono, estado, ciudad, pasatiempos,calificacion);

            //**** Agragamos el objeto a la lista simple ****//
            lstAspirantes.Items.Add(objAlumno);

            //Limpiamos los campos del formulario
            txtMatricula.Text = "";
            txtNombre.Text = "";
            /* sexo */
                rbtFemenino.Checked = false;
                rbtMasculino.Checked = false;
            /* --- */
            txtDirreccion.Text = "";
            txtTelefono.Text = "";
            cboEstados.Text = "";
            txtCiudad.Text = "";
            /* Pasatiempos */
                chkLeer.Checked = false;
                chkDeporte.Checked = false;
                chkPeliculas.Checked = false;
                chkMusica.Checked = false;
                chkAmigos.Checked = false;
                chkViajar.Checked = false;
            /* --- */
            if (pictureBox1.Image == null)
            {
                return;
            }
            else
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Limpiamos los campos del formulario
            txtMatricula.Text = "";
            txtNombre.Text = "";
            /* sexo */
            rbtFemenino.Checked = false;
            rbtMasculino.Checked = false;
            /* --- */
            txtDirreccion.Text = "";
            txtTelefono.Text = "";
            cboEstados.Text = "";
            txtCiudad.Text = "";
            /* Pasatiempos */
            chkLeer.Checked = false;
            chkDeporte.Checked = false;
            chkPeliculas.Checked = false;
            chkMusica.Checked = false;
            chkAmigos.Checked = false;
            chkViajar.Checked = false;
            /* --- */
            if (pictureBox1.Image == null)
            {
                return;
            }
            else
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }
        private void btnMostrarls_Click(object sender, EventArgs e)
        {
            //Validadamos que haya al menos un elemento seleccionado en la lista.
            if (lstAspirantes.SelectedIndex < 0)
                return;

            //Obtenemos el elemento seleccionado en la lista.
            Alumno objAlumno = (Alumno)lstAspirantes.SelectedItem;

            //Mostramos los datos del objeto en un cuadro de dialogo.
            string msg = "Matricula: " + objAlumno.Matricula + "\n";
            msg += "Nombre:" + objAlumno.Nombre + "\n";
            msg += "Sexo: " + objAlumno.Sexo + "\n";
            msg += "Fotografia: " + objAlumno.Fotografia + "\n";
            msg += "Dirreccion: " + objAlumno.Direccion + "\n";
            msg += "Telefono: " + objAlumno.Telefono + "\n";
            msg += "Estado: " + objAlumno.Estado + "\n";
            msg += "Ciudad: " + objAlumno.Ciudad + "\n";
            msg += "Pasatiempos: " + objAlumno.Pasatiempos + "\n";
            MessageBox.Show(this, msg, "Alumno Aspirante", MessageBoxButtons.OK);
        }

        //btn /*Accion para realizar Examen
        private void btnRealizarExamen_Click(object sender, EventArgs e)
        {

            //Validadamos que haya al menos un elemento seleccionado en la lista.
            if (lstAspirantes.SelectedIndex < 0)
                return;

            //Obtenemos el elemento seleccionado en la lista.
            Alumno objAlumno = (Alumno)lstAspirantes.SelectedItem;

            Examen ventanaExamen = new Examen(objAlumno);
            ventanaExamen.ShowDialog();

            object[] elementos = new object[lstAspirantes.Items.Count];
            lstAspirantes.Items.CopyTo(elementos, 0);
            lstAspirantes.Items.Clear();
            lstAspirantes.Items.AddRange(elementos);
        }

        private void btnAgregarAceptado_Click(object sender, EventArgs e)
        {
            //Validadamos que haya al menos un elemento seleccionado en la lista.
            if (lstAspirantes.SelectedIndex < 0)
                return;

            //Obtenemos el elemento seleccionado en la lista.
            Alumno objAlumno = (Alumno)lstAspirantes.SelectedItem;

            if (objAlumno.Calificacion > 6)
            {
                lstAceptados.Items.Add(objAlumno);
            }

            int index = lstAspirantes.SelectedIndex;

            lstAspirantes.Items.RemoveAt(index);
        }

        private void btnMostrarAceptados_Click(object sender, EventArgs e)
        {
            //Validadamos que haya al menos un elemento seleccionado en la lista.
            if (lstAceptados.SelectedIndex < 0)
                return;

            //Obtenemos el elemento seleccionado en la lista.
            Alumno objAlumno = (Alumno)lstAceptados.SelectedItem;

            //Mostramos los datos del objeto en un cuadro de dialogo.
            string msg = "Matricula: " + objAlumno.Matricula + "\n";
            msg += "Nombre:" + objAlumno.Nombre + "\n";
            msg += "Sexo: " + objAlumno.Sexo + "\n";
            msg += "Dirreccion: " + objAlumno.Direccion + "\n";
            msg += "Telefono: " + objAlumno.Telefono + "\n";
            msg += "Estado: " + objAlumno.Estado + "\n";
            msg += "Ciudad: " + objAlumno.Ciudad + "\n";
            msg += "Pasatiempos: " + objAlumno.Pasatiempos + "\n";
            MessageBox.Show(this, msg, "Alumno Aspirante", MessageBoxButtons.OK);
        }

        private void btnAgregarAspirante_Click(object sender, EventArgs e)
        {
            //Validadamos que haya al menos un elemento seleccionado en la lista.
            if (lstAceptados.SelectedIndex < 0)
                return;

            //Obtenemos el elemento seleccionado en la lista.
            Alumno objAlumno = (Alumno)lstAceptados.SelectedItem;

            if (objAlumno.Calificacion <= 10)
            {
                lstAspirantes.Items.Add(objAlumno);
            }

            int index = lstAceptados.SelectedIndex;

            lstAceptados.Items.RemoveAt(index);
        }
    }
}

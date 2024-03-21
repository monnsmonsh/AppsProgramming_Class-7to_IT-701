using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoTablas
{
    public partial class RegistroDiscos : Form
    {
        public RegistroDiscos()
        {
            InitializeComponent();
        }

        private void RegistroDiscos_Load(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string image = openFileDialog1.FileName;
                    picBxPortada.Image = Image.FromFile(image);
                    picBxPortada.ImageLocation = image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El arhivo seleccionado no es un " + " tipo de imagen valido");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Obtenemos los datos del formulario
            string titulo = txtTitulo.Text;
            string artista = txtArtista.Text;
            int numPistas = (int)spnNumPistas.Value;
            DateTime fechaE = dtpFechaE.Value;
            double precio = Double.Parse(txtPrecio.Text);
            string rutaImg = picBxPortada.ImageLocation;

            //Agregamos el nuevo disco a la tabla.
            object[] disco = { Image.FromFile(picBxPortada.ImageLocation), titulo, artista, numPistas, fechaE, precio };
            tblDiscos.Rows.Add(disco);

            //Limpiamos los campos.
            txtTitulo.Text = "";
            txtArtista.Text = "";
            spnNumPistas.Value = 0;
            dtpFechaE.Value = DateTime.Today;
            txtPrecio.Text = "";
            picBxPortada.Image = null;
            picBxPortada.ImageLocation = "";

        }

        private void btbCancelar_Click(object sender, EventArgs e)
        {
            //Limpiamos los campos.
            txtTitulo.Text = "";
            txtArtista.Text = "";
            spnNumPistas.Value = 0;
            dtpFechaE.Value = DateTime.Today;
            txtPrecio.Text = "";
            picBxPortada.Image = null;
            picBxPortada.ImageLocation = "";
        }
    }
}

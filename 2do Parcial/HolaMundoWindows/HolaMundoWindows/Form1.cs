using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundoWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            //Recuperar texto de la caja
            string nombre = txtNombre.Text;

            //Modificando el tecto de la etiqueta lblSaludo
            lblSaludo.Text = "Hola" + nombre + "desde WindowsForms";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSaludar_Click(object sender, EventArgs e)
        {

        }
    }
}

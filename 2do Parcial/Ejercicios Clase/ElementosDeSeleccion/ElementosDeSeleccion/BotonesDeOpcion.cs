using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementosDeSeleccion
{
    public partial class BotonesDeOpcion : Form
    {
        private int numeroActual;
        public BotonesDeOpcion()
        {
            InitializeComponent();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            //Validar el contenido del cuadro de texto
            if (txtNumero.Text.Length == 0) return;

            string numero = txtNumero.Text;
            int baseNum = 0;

            //Verificar el estado de los radioButton.
            if (rbtDecimal.Checked)
                baseNum = 10;
            else if (rbtOctal.Checked)
                baseNum = 8;
            else if (rbtHexadecimal.Checked)
                baseNum = 16;

            //Convertimos el texto a numero segun la base seleccionada
            try
            {
                numeroActual = Convert.ToInt32(numero, baseNum);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void rbtDecimal_CheckedChanged(object sender, EventArgs e)
        {
            //Verificar el estado de los radiosButtons.
            if (rbtDecimal.Checked)
                txtNumero.Text = Convert.ToString(numeroActual, 10);
            else if(rbtOctal.Checked)
                txtNumero.Text = Convert.ToString(numeroActual, 8);
            else if (rbtHexadecimal.Checked)
                txtNumero.Text = Convert.ToString(numeroActual, 16).ToUpper();
            txtNumero.Focus();
        }

        private void rbtOctal_CheckedChanged(object sender, EventArgs e)
        {
            //Verificar el estado de los radiosButtons.
            if (rbtDecimal.Checked)
                txtNumero.Text = Convert.ToString(numeroActual, 10);
            else if (rbtOctal.Checked)
                txtNumero.Text = Convert.ToString(numeroActual, 8);
            else if (rbtHexadecimal.Checked)
                txtNumero.Text = Convert.ToString(numeroActual, 16).ToUpper();
            txtNumero.Focus();
        }

        private void rbtHexadecimal_CheckedChanged(object sender, EventArgs e)
        {
            //Verificar el estado de los radiosButtons.
            if (rbtDecimal.Checked)
                txtNumero.Text = Convert.ToString(numeroActual, 10);
            else if (rbtOctal.Checked)
                txtNumero.Text = Convert.ToString(numeroActual, 8);
            else if (rbtHexadecimal.Checked)
                txtNumero.Text = Convert.ToString(numeroActual, 16).ToUpper();
            txtNumero.Focus();
        }
    }
}

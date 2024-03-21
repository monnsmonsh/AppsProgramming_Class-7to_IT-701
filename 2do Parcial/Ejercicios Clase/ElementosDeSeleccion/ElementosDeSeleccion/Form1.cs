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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkMayusculas_CheckedChanged(object sender, EventArgs e)
        {
            string texto = txtTexto.Text;

            //Verificamos el estado de la casilla de verificacion
            if(chkMayusculas.Checked)
            {
                //Convertimos el texto a mayusculas
                txtTexto.Text = texto.ToUpper();
            }
            else
            {
                //Convertimos a minusculas
                txtTexto.Text = texto.ToLower();
            }
            //Ponemos el cursor al final del texto
            txtTexto.Focus();
            txtTexto.SelectionStart = txtTexto.Text.Length;


        }
    }
}

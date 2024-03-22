using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenusBarraHerramientas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mitemSalir_Click(object sender, EventArgs e)
        {
            //Cerrar la ventana
            this.Dispose();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mitemAbrir_Click(object sender, EventArgs e)
        {
            //Abrir una nueva ventana
            CajasDialogos objVentana = new CajasDialogos();
            objVentana.Visible = true;
        }
    }
}

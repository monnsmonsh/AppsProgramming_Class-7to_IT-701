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
    public partial class CajasDialogos : Form
    {
        public CajasDialogos()
        {
            InitializeComponent();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Este es un Mensaje de Informacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdvertencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Este es un Mensaje de Advertencia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Este es un Mensaje de Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnConfirmacion1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show(this, "Selecciona una Opción", "Dialogo de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
                MessageBox.Show("Se selecciono el boton SI");
            else
                MessageBox.Show("Se selecciono el boton NO");

        }

        private void btnConfirmacion2_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show(this, "Selecciona una Opción", "Dialogo de Confirmacion", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Abort)
                MessageBox.Show("Se selecciono el boton ANULAR");
            else if (respuesta == DialogResult.Retry)
                MessageBox.Show("Se selecciono el boton REINTENTAR");
            else
                MessageBox.Show("Se selecciono el boton IGNORAR");
        }

        private void btnMostarDialogo_Click(object sender, EventArgs e)
        {
            string texto = Microsoft.VisualBasic.
                Interaction.InputBox("Texto de la pregunta", "Titulo de dialogo", "Respuesta por dedento");

            MessageBox.Show(this, texto, "Texto capturado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

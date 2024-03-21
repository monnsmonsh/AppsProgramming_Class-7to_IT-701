using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordBLock
{
    public partial class Form1 : Form
    {
        private Font fuentePr;
        public Form1()
        {
            InitializeComponent();
        }

        //   mbarMenuPrincipal
        //
        //      mnu
        private void mitemAbrir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Archivo > Abrir");
        }

        private void mitemSalir_Click(object sender, EventArgs e)
        {
            Close(); // cerrar el formulario principal 
        }
        private void mitemCortar_Click(object sender, EventArgs e)
        {
            //Se utilza el metodo cut para cortar lo que este seleccionado en txtTexto
            txtTexto.Cut();
        }

        private void mitemCopiar_Click(object sender, EventArgs e)
        {
            //Se utilza el metodo copy para copiar lo que este seleccionado en txtTexto
            txtTexto.Copy();
        }

        private void mitemPegar_Click(object sender, EventArgs e)
        {
            //Se utilza el metodo paste para pegar lo que tenemos copiado en txtTexto
            txtTexto.Paste();
        }
        private void mitemAtras_Click(object sender, EventArgs e)
        {
            //Se utiliza el metodo UNDO para volver atras
            txtTexto.Undo();
        }
        
        //      mnu
        private void mnucboFuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTexto.Font = new Font(mnucboFuente.SelectedItem.ToString(),
            txtTexto.Font.Size,
            txtTexto.Font.Style);

            /*
            Font f = txtTexto.Font;
            switch (mnucboFuente.SelectedIndex)
            {
                case 0:
                    txtTexto.Font = new Font("Courier new", f.Size, f.Style);
                case 1:
                    txtTexto.Font = new Font("Arial", f.Size, f.Style);
                case 2:
                    txtTexto.Font = new Font(fuentePr.SystemFontName,
                    f.Size, f.Style);
            }
            */
        }
        private void mnucboTam_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTexto.Font = new Font(txtTexto.Font.SystemFontName, float.Parse(mnucboTam.SelectedItem.ToString()), txtTexto.Font.Style);
        }
        //
        //...mbarMenuPrincipal

        //...Botones de la barra tolSrip
        private void btnitemEdicionCortar_Click(object sender, EventArgs e)
        {
            //Se utilza el metodo cut para cortar lo que este seleccionado en txtTexto
            txtTexto.Cut();
        }
        private void btnitemEdicionPegar_Click(object sender, EventArgs e)
        {
            //Se utilza el metodo paste para pegar lo que tenemos copiado en txtTexto
            txtTexto.Paste();
        }

        private void btnitemEdicionCopiar_Click(object sender, EventArgs e)
        {
            //Se utilza el metodo copy para copiar lo que este seleccionado en txtTexto
            txtTexto.Copy();
        }
        private void btnitemEdicionVolver_Click(object sender, EventArgs e)
        {
            //Se utiliza el metodo UNDO para volver atras
            txtTexto.Undo();
        }



        //...Botones de la barra tolSrip

        private void Form1_Load(object sender, EventArgs e)
        {
            fuentePr = txtTexto.Font;
            
            mnucboFuente.Text = txtTexto.Font.SystemFontName;
            mnucboFuente.Items.AddRange(new object[] {"Courier New", "Arial", txtTexto.Font.SystemFontName });
            mnucboTam.Text = txtTexto.Font.Size.ToString();
            mnucboTam.Items.AddRange(new object[] {"16", "24", txtTexto.Font.Size.ToString() });

            /*
            mnucboFuente.Items.AddRange(new Object[] { "Courier new", "Arial", "Predeterminada" });
            mnucboFuente.Text = "Predeterminada";
            */
        }

        private void cnmitemCortar_Click(object sender, EventArgs e)
        {
            //Se utilza el metodo copy para copiar lo que este seleccionado en txtTexto
            txtTexto.Cut();
        }

        private void cnmitemCopiar_Click(object sender, EventArgs e)
        {
            //Se utilza el metodo copy para copiar lo que este seleccionado en txtTexto
            txtTexto.Copy();
        }

        private void cnmitemPegar_Click(object sender, EventArgs e)
        {
            //Se utilza el metodo copy para copiar lo que este seleccionado en txtTexto
            txtTexto.Paste();
        }

        private void cnmitemAtras_Click(object sender, EventArgs e)
        {
            //Se utiliza el metodo UNDO para volver atras
            txtTexto.Undo();
        }

        
    }
    
}

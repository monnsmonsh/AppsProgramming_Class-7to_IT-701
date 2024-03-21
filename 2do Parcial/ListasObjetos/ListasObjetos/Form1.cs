using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasObjetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //********* Extraemos los datos del formulario *********//
            string titulo = txtTitulo.Text;
            string artista = txtArtista.Text;
            int numPistas = (int)spnNumPistas.Value;
            DateTime fechaLanzamineto = dtpFechaLanzamiento.Value;
            double precio = Double.Parse(txtPrecio.Text);

            //Creamos un nuevo objeto de la clase Disco
            Disco objDisco = new Disco(titulo, artista, numPistas, fechaLanzamineto, precio);

            //**** Agragamos el objeto a la lista simple ****//
            lstDiscos.Items.Add(objDisco);


            //*** Agregamos a lista de tipo "cbo"
            cboListaDisco.Items.Add(objDisco);

            //Limpiamos los campos del formulario
            txtTitulo.Text = "";
            txtArtista.Text = "";
            spnNumPistas.Value = 0;
            dtpFechaLanzamiento.Value = DateTime.Today;
            txtPrecio.Text = "";


            
        }

        private void btnMostrarls_Click(object sender, EventArgs e)
        {
            //Validadamos que haya al menos un elemento seleccionado en la lista.
            if (lstDiscos.SelectedIndex < 0)
                return;

            //Obtenemos el elemento seleccionado en la lista.
            Disco objDisco = (Disco)lstDiscos.SelectedItem;

            //Mostramos los datos del objeto en un cuadro de dialogo.
            string msg = "Titulo: " + objDisco.Titulo + "\n";
            msg+= "Artista:" +objDisco.Artista + "\n";
            msg+= "Numero de Pistas: "+ objDisco.NumPistas + "\n"; 
            msg+= "Fecha de Lanzamiento: " + objDisco.FechaLanzamiento + "\n";
            msg+= "Precio: " + objDisco.Precio + "\n";
            MessageBox.Show(this, msg, "Disco Seleccionado", MessageBoxButtons.OK);

        }

        private void btnMostrarVariosls_Click(object sender, EventArgs e)
        {
            //Verificando que este seleccionado al menos un elemento.
            if (lstDiscos.SelectedIndex < 0)
                return;

            //obtenemos los elementos seleecionados de la lista
            ListBox.SelectedObjectCollection objDiscoCollection = lstDiscos.SelectedItems;

            //mostrando los elementos Seleccionados
            foreach (object elemento in objDiscoCollection)
            {
                //Obtenemos el elemento seleccionado en la lista.
                Disco objDisco = (Disco)lstDiscos.SelectedItem;

                //Mostramos los datos del objeto en un cuadro de dialogo.
                string msg = "Titulo: " + objDisco.Titulo + "\n";
                msg += "Artista:" + objDisco.Artista + "\n";
                msg += "Numero de Pistas: " + objDisco.NumPistas + "\n";
                msg += "Fecha de Lanzamiento: " + objDisco.FechaLanzamiento + "\n";
                msg += "Precio: " + objDisco.Precio + "\n";
                MessageBox.Show(this, msg, "Disco Seleccionado", MessageBoxButtons.OK);
            }
        }

        private void btnEliminarls_Click(object sender, EventArgs e)
        {
            //Verificando que este seleccionado al menos un elemento.
            if (lstDiscos.SelectedIndex < 0)
                return;

            //obtenemos el indice del elemnto seleccionado
            int index = lstDiscos.SelectedIndex;

            //Eliminamos el elemento seleccionado en base al indice.
            lstDiscos.Items.RemoveAt(index);
        }

        private void btnMostrarcbo_Click(object sender, EventArgs e)
        {
            //Validadamos que haya al menos un elemento seleccionado en la lista.
            if (cboListaDisco.SelectedIndex < 0)
                return;

            //Obtenemos el elemento seleccionado en la lista.
            Disco objDisco = (Disco)cboListaDisco.SelectedItem;

            //Mostramos los datos del objeto en un cuadro de dialogo.
            string msg = "Titulo: " + objDisco.Titulo + "\n";
            msg += "Artista:" + objDisco.Artista + "\n";
            msg += "Numero de Pistas: " + objDisco.NumPistas + "\n";
            msg += "Fecha de Lanzamiento: " + objDisco.FechaLanzamiento + "\n";
            msg += "Precio: " + objDisco.Precio + "\n";
            MessageBox.Show(this, msg, "Disco Seleccionado", MessageBoxButtons.OK);
        }

        private void btnEliminarcbo_Click(object sender, EventArgs e)
        {
            //Verificando que este seleccionado al menos un elemento.
            if (cboListaDisco.SelectedIndex < 0)
                return;

            //obtenemos el indice del elemnto seleccionado
            int index = cboListaDisco.SelectedIndex;

            //Eliminamos el elemento seleccionado en base al indice.
            cboListaDisco.Items.RemoveAt(index);
        }
    }
}

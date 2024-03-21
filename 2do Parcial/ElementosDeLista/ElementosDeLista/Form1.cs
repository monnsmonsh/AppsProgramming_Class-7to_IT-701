using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementosDeLista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgrgar_Click(object sender, EventArgs e)
        {
            //Recuperando el nombre escrito en la caja de text
            string nombre = txtEx.Text;

            //Agregamos el nombre a la lista
            lstExParejas.Items.Add(nombre);
            cboListaExParejas.Items.Add(nombre);

            //Limpiamos la caja de texto
            txtEx.Text = "";

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Verificando que este seleccionado al menos un elemento.
            if (lstExParejas.SelectedIndex < 0)
                return;

            //Obtenemos el elemento seleccionado
            string nombre = lstExParejas.SelectedItem.ToString();

            //Mostrando el elemento seleccionado
            MessageBox.Show(nombre, "Te Extraño");
        }

        private void btnMosVarios_Click(object sender, EventArgs e)
        {
            //Verificando que este seleccionado al menos un elemento.
            if (lstExParejas.SelectedIndex < 0)
                return;

            //obtenemos los elementos seleecionados de la lista
            ListBox.SelectedObjectCollection nombres = lstExParejas.SelectedItems;

            //mostrando los elementos Seleccionados
            foreach (object nombre in nombres)
            {
                MessageBox.Show(nombre.ToString(), "Te extraño");
            }
        }

        private void btnOlvidar_Click(object sender, EventArgs e)
        {
            //Verificando que este seleccionado al menos un elemento.
            if (lstExParejas.SelectedIndex < 0)
                return;

            //obtenemos el indice del elemnto seleccionado
            int index = lstExParejas.SelectedIndex;

            //Eliminamos el elemento seleccionado en base al indice.
            //lstExParejas.Items.RemoveAt(index);
            lstExParejas.Items.Clear();//Borramos todos los elemntos
        }





        private void btnMostar2_Click(object sender, EventArgs e)
        {
            //Verificando que este seleccionado al menos un elemento.
            if (cboListaExParejas.SelectedIndex < 0)
                return;

            //Obtenemos el elemento seleccionado
            string nombre = cboListaExParejas.SelectedItem.ToString();

            //Mostrando el elemento seleccionado
            MessageBox.Show(nombre, "Te Extraño");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Verificando que este seleccionado al menos un elemento.
            if (cboListaExParejas.SelectedIndex < 0)
                return;

            //obtenemos el indice del elemnto seleccionado
            int index = cboListaExParejas.SelectedIndex;

            //Eliminamos el elemento seleccionado en base al indice.
            cboListaExParejas.Items.RemoveAt(index);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cboListaExParejas.SelectedIndex < 0)
                return;

            //Obtenemos el elemento seleccionado
            string nombre = cboListaExParejas.SelectedItem.ToString();

            string texto = Microsoft.VisualBasic.
                Interaction.InputBox("Modificar", "Escribe el nuevo nombre", nombre);


            MessageBox.Show(this, nombre, "Texto capturado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

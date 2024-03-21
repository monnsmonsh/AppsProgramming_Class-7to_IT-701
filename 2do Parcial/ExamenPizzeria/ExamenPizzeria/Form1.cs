using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPizzeria
{
    public partial class Form1 : Form
    {
        private int totalVentas = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            //********* Extraemos los datos del formulario *********//
            string nombre = txtNombre.Text;
            string dirrecion = txtDirrecion.Text;
            string telefono = txtTelefono.Text;
            /*tamaño pizza*/
            int tamPizza = 0;
            
            if (rbtChica.Checked)
                tamPizza = 40;
            else if (rbtMediana.Checked)
                tamPizza = 80;
            else if (rbtGrande.Checked)
                tamPizza = 120;

            string tamPizzatxt = "";
            if (rbtChica.Checked)
                tamPizzatxt = "Chica";
            else if (rbtMediana.Checked)
                tamPizzatxt = "Mediana";
            else if (rbtGrande.Checked)
                tamPizzatxt = "Grande";
            /*--------*/
            /*Ingredientes*/
            int ingrePizza =0;
            if (chkJamon.Checked == true)
                ingrePizza = ingrePizza + 10;
            if (chkPina.Checked == true)
                ingrePizza = ingrePizza + 10;
            if (chkChampinones.Checked == true)
                ingrePizza = ingrePizza + 10;
            string ingrePizzatxt = "";
            if (chkJamon.Checked == true)
                ingrePizzatxt = ingrePizzatxt + "Jamon, ";
            if (chkPina.Checked == true)
                ingrePizzatxt = ingrePizzatxt + "Piña, ";
            if (chkChampinones.Checked == true)
                ingrePizzatxt = ingrePizzatxt + "Champiñones ";
            /* --------- */

            int numPizza= (int)spnNumPizzas.Value;
            int totalPizza = 0;

            totalPizza = numPizza * (tamPizza + ingrePizza);

            //Creamos un nuevo objeto de la clase Disco
            Pizza objPizza = new Pizza(nombre, dirrecion, telefono,tamPizza, tamPizzatxt, ingrePizza, ingrePizzatxt, numPizza,totalPizza);


            //Mostramos los datos del objeto en un cuadro de dialogo.
            string msg = "EL total de tu orden es: " + objPizza.TotalPizza + "\n";
            msg += "\n";
            msg += "¿Deseas realizar Pedido?";
            //mostrar una ventana de advertencia sobre el pedido a realizar
            DialogResult respuesta;
            respuesta = MessageBox.Show(this, msg, "Pedio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes) {
                //**** Agragamos el objeto a la lista simple ****//
                lstPizzas.Items.Add(objPizza);

                //Limpiamos los campos del formulario
                txtNombre.Text = "";
                txtDirrecion.Text = "";
                txtTelefono.Text = "";
                /*tamaño pizza*/
                rbtChica.Checked = false;
                rbtMediana.Checked = false;
                rbtGrande.Checked = false;
                /* --- */
                /*ingredientes pizza*/
                chkChampinones.Checked = false;
                chkJamon.Checked = false;
                chkPina.Checked = false;
                spnNumPizzas.Value = 1;

                totalVentas = totalVentas + totalPizza;
                lblTotal.Text = Convert.ToString(totalVentas);
            }


            
        }

        private void btnMostrarls_Click(object sender, EventArgs e)
        {
            //Validadamos que haya al menos un elemento seleccionado en la lista.
            if (lstPizzas.SelectedIndex < 0)
                return;

            //Obtenemos el elemento seleccionado en la lista.
            Pizza objPizza = (Pizza)lstPizzas.SelectedItem;

            //Mostramos los datos del objeto en un cuadro de dialogo.
            string msg = "Nombre: " + objPizza.Nombre + "\n";
            msg += "Dirrecion:" + objPizza.Dirrecion + "\n";
            msg += "Telefono: " + objPizza.Telefono + "\n";
            msg += "Tamaño de Pizza: " + objPizza.TamPizzatxt + "\n";
            msg += "Ingredientes: " + objPizza.IngrePizzatxt + "\n";
            msg += "Cantidad: " + objPizza.NumPizza + " pizzas"+"\n";
            MessageBox.Show(this, msg, "Pedido Seleccionado", MessageBoxButtons.OK);
        }
        //Limpiamos los campos del formulario
        /*txtNombre.Text = "";
        txtDirrecion.Text = "";
        txtTelefono.Text = "";
        spnNumPizzas.Value = 0;
        */
    }
}

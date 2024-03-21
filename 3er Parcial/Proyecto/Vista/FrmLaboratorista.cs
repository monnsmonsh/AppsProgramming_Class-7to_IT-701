using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Controlador;
using Modelo;

namespace Vista
{
    public partial class FrmLaboratorista : Form
    {
        public FrmLaboratorista()
        {
            InitializeComponent();
        }

        //Variables globales a la clase.
        List<DetalleLaboratorista> lstLaboratorista = new List<DetalleLaboratorista>();

        private void FrmLaboratorista_Load(object sender, EventArgs e)
        {
            CargarDatos();
            lblValFecha.Text = DateTime.Today.ToString();
        }


        public void CargarDatos()
        {
            //Creamos los objetos de la clase Controlador.
            DiscoMgr objLaboratoristaMgr = new DiscoMgr();
            ClienteMgr objLaboratoristaMgr = new ClienteMgr();
            try
            {
                //Cargamos los discos disponibles al ComboBox de Discos.
                cboDiscos.Items.AddRange(objLaboratoristaMgr.ObtenerDiscosList().ToArray());
                //Cargamos los clientes disponibles al ComboBox de Clientes.
                cboCliente.Items.AddRange(objLaboratoristaMgr.ObtenerClientesList().ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Base de Datos");
            }

        }


        private void LimpiarCampos()
        {
            //Limpiamos todos los campos del formulario.
            cboCliente.SelectedIndex = -1;
            cboDiscos.Text = "";
            txtCantidad.Text = "1";
            txtNoFactura.Text = "";
            txtObservaciones.Text = "";
            cboCliente.SelectedIndex = -1;
            cboCliente.Text = "";
            lblValRfc.Text = "";
            lblValNombre.Text = "";
            lbl1ValColonia.Text = "";
            dgvDetalleVenta.Rows.Clear();
            lstDetalle.Clear();

            //Borrando Valores.
            subTotal = 0.0;
            lblValSubtotal.Text = "$0.00";
            lblValIva.Text = "$0.00";
            lblValTotal.Text = "$0.00";

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Recuperamos el objeto Disco seleccionado en la lista de discos.
            Disco objDisco = (Disco)cboDiscos.SelectedItem;

            //Acumulamos el costo total del producto al subtotal.
            subTotal += objDisco.Precio * Convert.ToInt32(txtCantidad.Text);

            //Generamos el array a pasar a la tabla.
            object[] detalle = { dgvDetalleVenta.RowCount+1, //id
                cboDiscos.SelectedItem,//objeto Disco
                Convert. ToInt32(txtCantidad. Text), //cantidad
                objDisco.Precio,//precio
                objDisco.Precio * Convert. ToInt32(txtCantidad.Text)};//total

            //Agregamos el detalle a la tabla y a la lista de objetos detalle.
            dgvDetalleVenta.Rows.Add(detalle);
            DetalleVenta objDetalle = new DetalleVenta();
            objDetalle.IdDisco = objDisco.IdDisco;
            objDetalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
            objDetalle.Precio = objDisco.Precio;
            lstDetalle.Add(objDetalle);

            //Limpiamos los campos.
            cboDiscos.Text = "";
            txtCantidad.Text = "1";
            lblValSubtotal.Text = "$" + Convert.ToString(subTotal);
            lblValIva.Text = "$" + Convert.ToString(subTotal * 0.16);
            lblValTotal.Text = "$" + Convert.ToString(subTotal * 1.16);
        }

        private void cboCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboCliente.SelectedItem != null)
            {
                Cliente objCliente = (Cliente)cboCliente.SelectedItem;
                lblValRfc.Text = objCliente.Rfc;
                lblValNombre.Text = objCliente.Nombre;
                lbl1ValColonia.Text = objCliente.Colonia;

            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetalleVenta.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection rows = dgvDetalleVenta.SelectedRows;
                foreach (DataGridViewRow row in rows)
                {
                    //Disminuimos el subtotal.
                    subTotal -= (double)row.Cells[4].Value;

                    //Quitamos el objeto de la lista de detalle.
                    lstDetalle.RemoveAt(row.Index);

                    //Quitamos la fila de la tabla.
                    dgvDetalleVenta.Rows.RemoveAt(row.Index);

                    //Actualizamos los Totales
                    lblValSubtotal.Text = "$" + Convert.ToString(subTotal);
                    lblValIva.Text = "$" + Convert.ToString(subTotal * 0.16);
                    lblValTotal.Text = "$" + Convert.ToString(subTotal * 1.16);

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            //Creamos un objeto de la clase venta con todos sus datos.
            Venta objVenta = new Venta(txtNoFactura.Text, DateTime.Today,
            ((Cliente)cboCliente.SelectedItem).IdCliente, txtObservaciones.Text, lstDetalle);

            //Creamos un objeto de la clase VentaMgr.
            VentaMgr objVentaMgr = new VentaMgr(objVenta);
            try
            {
                //Mandamos a Guardar la Venta a la BD.
                if (objVentaMgr.InsertarVenta())
                {
                    MessageBox.Show(this, "La Venta se ha Guardado", "Punto de Venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Base de Datos");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
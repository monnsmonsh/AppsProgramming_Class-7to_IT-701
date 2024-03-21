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
    public partial class ReportesVentas : Form
    {
        public ReportesVentas()
        {
            InitializeComponent();
            ConsultarVentas();

        }

        private void ReportesVentas_Load(object sender, EventArgs e)
        {

        }
        public void ConsultarVentas()
        {
            //Creamos un objeto de la clase VentaMgr.
            VentaMgr objVentaMgr = new VentaMgr();
            try
            {
                //Creamos un objeto DataSet para almacenar el conjunto de datos de Ventas.
                DataSet dsVentas = objVentaMgr.ConsultarVentas();

                //Asignamos el DataSet al DataGridView.
                dgvVentas.DataSource = dsVentas;
                dgvVentas.DataMember = "Resultado";

                //Establecemos los encabezados a las columnas del DataGridView
                dgvVentas.Columns[0].HeaderText = "Num. Venta";
                dgvVentas.Columns[1].HeaderText = "Fecha" ;
                dgvVentas.Columns[2].HeaderText = "Cliente";
                dgvVentas.Columns[3].HeaderText = "SubTotal";
                dgvVentas.Columns[4].HeaderText = "IVA";
                dgvVentas.Columns[5].HeaderText = "Total";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Base de Datos");
            }
        }

        private void dgvVentas_Click(object sender, EventArgs e)
        {
            //Obtenemos el Índice de la fila seleccionada
            int f = dgvVentas.CurrentCellAddress.Y;
            //Recuperamos el Num. Venta del DataGrid.
            string numVenta = Convert.ToString(dgvVentas.Rows[f].Cells[0].Value);

            //Creamos un objeto de la clase VentaMgr.
            VentaMgr objVentaMgr = new VentaMgr();
            try
            {
                //Creamos un objeto DataSet para almacenar el conjunto de datos de Ventas.
                DataSet dsDetalleVenta = objVentaMgr.ConsultarDetalleVenta(numVenta);
                //Asignamos el DataSet al DataGridView.
                dgvDetalleVentas.DataSource = dsDetalleVenta;
                dgvDetalleVentas.DataMember = "Resultado";
                //Establecemos los encabezados a las columnas del DataGridView
                dgvDetalleVentas.Columns[0].HeaderText = "Num. Venta";
                dgvDetalleVentas.Columns[1].HeaderText = "Título";
                dgvDetalleVentas.Columns[2].HeaderText = "Cantidad";
                dgvDetalleVentas.Columns[3].HeaderText = "Precio";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Base de Datos");
            }
        }
    }
}

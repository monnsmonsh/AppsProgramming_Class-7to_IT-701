using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DineroDividir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            //Recuperar texto de la caja
            double money = Convert.ToDouble(txtCantidad.Text);

            DesgloseMoneda objDesgloseMoneda = new DesgloseMoneda(money);

            //Mostramos el resultado en la etiqueta lblResultado
            lblP500.Text = Convert.ToString(objDesgloseMoneda.M500());
            lblP200.Text = Convert.ToString(objDesgloseMoneda.M200());
            lblP100.Text = Convert.ToString(objDesgloseMoneda.M100());
            lblP50.Text = Convert.ToString(objDesgloseMoneda.M50());
            lblP20.Text = Convert.ToString(objDesgloseMoneda.M20());
            lblP10.Text = Convert.ToString(objDesgloseMoneda.M10());
            lblP5.Text = Convert.ToString(objDesgloseMoneda.M5());
            lblP2.Text = Convert.ToString(objDesgloseMoneda.M2());
            lblP1.Text = Convert.ToString(objDesgloseMoneda.M1());
        }
    }
}

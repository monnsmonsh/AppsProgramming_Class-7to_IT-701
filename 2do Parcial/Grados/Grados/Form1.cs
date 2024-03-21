using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grados
{
    public partial class Form1 : Form
    {

        private TextBox objTextBox = null;

        private ErrorProvider ProveedorDeError;
        
        private double datoCajaTexto;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtGradosC.Select();
        }

    
       
        private void txtGradosC_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            if (e.KeyChar == Convert.ToChar(13))
            {
                // Se pulsó la tecla Entrar
                e.Handled = true;
                // Cambiar el foco a otro control
                if (objTextBox == txtGradosC)
                {
                    txtGradosF.Focus();
                }
                else
                {
                    txtGradosC.Focus();
                }
            }
        }
        private void txtGradosC_Enter(object sender, EventArgs e)
        {
            TextBox ObjTextBox = (TextBox)sender;
            ObjTextBox.SelectAll();
        }

        private void txtGradosC_Validating(object sender, CancelEventArgs e)
        {
            ProveedorDeError = new ErrorProvider();
            // ...
            TextBox objTextBox = (TextBox)sender;
            try
            {
                datoCajaTexto = Convert.ToDouble(objTextBox.Text);
            }
            catch (Exception)
            {
                e.Cancel = true;
                objTextBox.SelectAll();
                ProveedorDeError.SetError(objTextBox, "Tiene que ser numérico");
            }
        }
        private void txtGradosC_Validated(object sender, EventArgs e)
        {
            ProveedorDeError.Clear();
            Conversion(sender);
        }
        private void txtGradosF_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            if (e.KeyChar == Convert.ToChar(13))
            {
                // Se pulsó la tecla Entrar
                e.Handled = true;
                // Cambiar el foco a otro control
                if (objTextBox == txtGradosC)
                {
                    txtGradosF.Focus();
                }
                else
                {
                    txtGradosC.Focus();
                }
            }
        }
        
        private void txtGradosF_Enter(object sender, EventArgs e)
        {
            TextBox ObjTextBox = (TextBox)sender;
            ObjTextBox.SelectAll();
        }
        private void txtGradosF_Validating(object sender, CancelEventArgs e)
        {
            ProveedorDeError = new ErrorProvider();
            // ...
            TextBox objTextBox = (TextBox)sender;
            try
            {
                datoCajaTexto = Convert.ToDouble(objTextBox.Text);
            }
            catch (Exception)
            {
                e.Cancel = true;
                objTextBox.SelectAll();
                ProveedorDeError.SetError(objTextBox, "Tiene que ser numérico");
            }
        }
        private void txtGradosF_Validated(object sender, EventArgs e)
        {
            ProveedorDeError.Clear();
            Conversion(sender);
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                double grados;
                // Si se escribió en la caja de texto grados centígrados...
                if (objTextBox == txtGradosC)
                {
                    grados = Convert.ToDouble(txtGradosC.Text) * 9.0 / 5.0 + 32.0;
                    // Mostrar el resultado redondeado a dos decimales
                    txtGradosF.Text = string.Format("{0:F2}", grados);
                }
                // Si se escribió en la caja de texto grados Fahrenheit...
                if (objTextBox == txtGradosF)
                {
                    grados = (Convert.ToDouble(txtGradosF.Text) - 32.0) * 5.0 / 9.0;
                    // Mostrar el resultado redondeado a dos decimales
                    txtGradosC.Text = string.Format("{0:F2}", grados);
                }
            }
            catch (FormatException)
            {
                txtGradosC.Text = "0.00";
                txtGradosF.Text = "32.00";
            }
        }

        private void Conversion(object sender)
        {
            TextBox objTextBox = (TextBox)sender;
            double grados;
            // Si se escribió en la caja de texto grados centígrados...
            if (objTextBox == txtGradosC)
            {
                grados = datoCajaTexto * 9.0 / 5.0 + 32.0;
                // Mostrar el resultado redondeado a dos decimales
                txtGradosF.Text = string.Format("{0:F2}", grados);
            }
            // Si se escribió en la caja de texto grados Fahrenheit...
            if (objTextBox == txtGradosF)
            {
                grados = (datoCajaTexto - 32.0) * 5.0 / 9.0;
                // Mostrar el resultado redondeado a dos decimales
                txtGradosC.Text = string.Format("{0:F2}", grados);
            }
        }

        





        private void Form1_Shown(object sender, EventArgs e)
        {
            txtGradosC.Focus();

        }

        
    }
}

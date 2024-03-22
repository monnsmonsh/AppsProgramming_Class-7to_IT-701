using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundoWindows
{
    public partial class Operaciones : Form
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            //Recuperamos los numeros de las cajas de texto.
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);

            //Creamos un objeto de la clase Artimetica
            Aritmetica objAritmetica = new Aritmetica(num1, num2);

            //Mostramos el resultado en la etiqueta lblResultado
            lblResultado.Text = Convert.ToString(objAritmetica.Sumar());


            /*double suma = num1 + num2;

            //Mostramos el resultado en la etiqueta lblResultado
            lblResultado.Text = Convert.ToString(suma);*/
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            //Recuperamos los numeros de las cajas de texto.
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);

            //Creamos un objeto de la clase Artimetica
            Aritmetica objAritmetica = new Aritmetica(num1, num2);

            //Mostramos el resultado en la etiqueta lblResultado
            lblResultado.Text = Convert.ToString(objAritmetica.Restar());
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //Recuperamos los numeros de las cajas de texto.
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);

            //Creamos un objeto de la clase Artimetica
            Aritmetica objAritmetica = new Aritmetica(num1, num2);

            //Mostramos el resultado en la etiqueta lblResultado
            lblResultado.Text = Convert.ToString(objAritmetica.Multiplicar());
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            //Recuperamos los numeros de las cajas de texto.
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);

            //Creamos un objeto de la clase Artimetica
            Aritmetica objAritmetica = new Aritmetica(num1, num2);

            if (num1==0 && num2 ==0)
            {
                lblResultado.Text = "No se puede dividir";
            }
            if(num2 == 0)
            {
                lblResultado.Text = "No se puede dividir";
            }
            else
            {
                double dividir = num1 / num2;

                //Mostramos el resultado en la etiqueta lblResultado
                lblResultado.Text = Convert.ToString(objAritmetica.Dividir());
            }
        }
    }
}

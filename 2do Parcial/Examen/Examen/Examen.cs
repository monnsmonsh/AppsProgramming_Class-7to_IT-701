using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Examen : Form
    {
        private Alumno objAlumno;
        int resultado = 0;
        //int seleccion = 1;
        int cal = 0;
        //Constructores
        //Constructores
        public Examen() { }
        public Examen(Alumno objAlumno) {
            InitializeComponent();
            this.objAlumno = objAlumno;
            txtNombre.Text = objAlumno.Nombre;
        }
        /*public Examen()
        {
            InitializeComponent();
        }
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        /*private void Limpiar()
        {
            this.rbtA1.Checked = true;
            this.rbtA2.Checked = true;
            this.rbtA3.Checked = true;
            this.chkA4.Checked = true;
            this.chkA5.Checked = true;
        }*/
        private void btnInicio_Click(object sender, EventArgs e)
        {
            //
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show(this, "Escribe tu nombre para continuar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                tabControl1.SelectedTab = tbpPregunta1;
            }
            
        }
        private void btnPreg1_Click(object sender, EventArgs e)
        {
            //Verificar el estado de los radioButton.
            if (rbtA1.Checked)
            {
                resultado = resultado + 2;
                lblResultado1.Text = "1.- Correcto";
            }
            else
            {
                resultado = resultado + 0;
                lblResultado1.Text = "1.- Incorecto";
            }
            /*Limpiar();*/
            tabControl1.SelectedTab = tbpPregunta2;
        }
        private void btnPreg2_Click(object sender, EventArgs e)
        {
            //Verificar el estado de los radioButton.
            if (rbtC2.Checked)
            {
                resultado = resultado + 2;
                lblResultado2.Text = "2.- Correcto";
            }
            else
            {
                resultado = resultado + 0;
                lblResultado2.Text = "2.- Incorrecto";
            }
            tabControl1.SelectedTab = tbpPregunta3;
        }

        private void btnPreg3_Click(object sender, EventArgs e)
        {
            //Verificar el estado de los radioButton.
            if (rbtC3.Checked)
            {
                resultado = resultado + 2;
                lblResultado3.Text = "3.- Correcto";

            }
            else
            {
                resultado = resultado + 0;
                lblResultado3.Text = "3.- Incorecto";
            }
            tabControl1.SelectedTab = tbpPregunta4;

        }

        private void btnPregunta4_Click(object sender, EventArgs e)
        {
            //Verificamos el estado de la casilla de verificacion
            if (chkA4.Checked ==true && chkB4.Checked ==true && chkC4.Checked == false && chkD4.Checked == false)
            {
                resultado = resultado + 2;
                lblResultado4.Text = "4.- Correcto";
            }
            else
            {
                resultado = resultado + 0;
                lblResultado4.Text = "4.- Incorrecto";
            }
            tabControl1.SelectedTab = tbpPregunta5;
        }

        private void btnPreg5_Click(object sender, EventArgs e)
        {
            //Verificamos el estado de la casilla de verificacion
            if (chkA5.Checked == true && chkD5.Checked ==true && chkB5.Checked== false && chkC5.Checked == false)
            {
                resultado = resultado + 2;
                lblResultado5.Text = "5.- Correcto";
            }
            else
            {
                resultado = resultado + 0;
                lblResultado5.Text = "4.- Incorrecto";
            }
            tabControl1.SelectedTab = tbpResultados;
            //Mostramos el resultado en la etiqueta lblResultado
            //lblCalificacion.Text = Convert.ToString(resultado);

            int cal = 0;
            //Pregunta1
            if (this.rbtA1.Checked == true)
            {
                cal = cal + 2;
            }
            else
            {
                cal = cal + 0;
            }
            //Pregunta2
            if (this.rbtC2.Checked == true)
            {
                cal = cal + 2;
            }
            //Pregunta3
            if (this.rbtC3.Checked == true)
            {
                cal = cal + 2;
            }
            else
            {
                cal = cal + 0;
            }
            //Pregunta4
            if (chkA4.Checked == true && chkB4.Checked == true && chkC4.Checked == false && chkD4.Checked == false)
            {
                cal = cal + 2;
            }
            else
            {
                cal = cal + 0;
            }
            //Pregunta5
            if (chkA5.Checked && chkD5.Checked == true && chkB5.Checked == false && chkC5.Checked == false)
            {
                cal = cal + 2;
            }
            else
            {
                cal = cal + 0;
            }
            lblCalificacion.Text = Convert.ToString(cal);
            //Recuperar texto de la caja
            string nombre = txtNombre.Text;
            //Modificando el tecto de la etiqueta lblSaludo
            
            if (cal <= 5)
            {
                string mensaje = " Hola " + nombre + " tu calificacion es: " + cal + " tu estatus es Reprobado. Necesitas poner mejor atencion";
                MessageBox.Show(mensaje, "Reprobado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (cal <= 7)
            {
                string mensaje = " Hola " + nombre + " tu calificacion es: " + cal+ " tu estatus es Aprobado. Necesitas mejorar";
                MessageBox.Show(mensaje, "APROVADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                string mensaje = " Hola " + nombre + " tu calificacion es: " + cal + " tu estatus es Aprobado. Felicidades";
                MessageBox.Show(mensaje, "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void btnCalificacion_Click(object sender, EventArgs e)
        {
            int cal = 0;
            //Pregunta1
            if (this.rbtA1.Checked == true)
            {
                cal = cal + 2;
            }
            else
            {
                cal = cal + 0;
            }
            //Pregunta2
            if (this.rbtC2.Checked == true)
            {
                cal = cal + 2;
            }
            //Pregunta3
            if (this.rbtC3.Checked == true)
            {
                cal = cal + 2;
            }
            else
            {
                cal = cal + 0;
            }
            //Pregunta4
            if (chkA4.Checked == true && chkB4.Checked == true && chkC4.Checked == false && chkD4.Checked == false)
            {
                cal = cal + 2;
            }
            else
            {
                cal = cal + 0;
            }
            //Pregunta5
            if (chkA5.Checked == true && chkD5.Checked == true)
            {
                cal = cal + 2;
            }
            else
            {
                cal = cal + 0;
            }
            lblCalificacion.Text = Convert.ToString(cal);

            


            txtNombre.Text = objAlumno.Nombre;
            objAlumno.Calificacion = Convert.ToInt32(cal);
            this.Close();
        }
   
        
    }
}

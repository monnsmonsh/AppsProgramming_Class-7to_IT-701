using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRestaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SidePanel.Height = btnInicio.Height;
            SidePanel.Top = btnInicio.Top;
            firstCustomControl1.BringToFront();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            
            SidePanel.Height = btnInicio.Height;
            SidePanel.Top = btnInicio.Top;
            firstCustomControl1.BringToFront();
        }

        private void btnSeccion2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSeccion2.Height;
            SidePanel.Top = btnSeccion2.Top;
            seconCustomControl1.BringToFront();
        }
    }
}

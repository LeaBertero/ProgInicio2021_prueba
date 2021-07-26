using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class HolaClase : Form
    {
        public HolaClase()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LblMensaje.Text = "Hola alumno de la materia - " + TxtMateria.Text;
        }

        private void btnaceptar2_Click(object sender, EventArgs e)
        {
            lblmensaje2.Text = "FELICITACIONES !! ";
        }
    }
}

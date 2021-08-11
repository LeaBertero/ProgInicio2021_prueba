using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerPrograma_HOLAMUNDO2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {


            if (this.LblMensaje.Text == "Chau")
            {
                this.LblMensaje.Text = "Hola Mundo";
            }
            else
            {
                this.LblMensaje.Text = "Chau";
            }
        }
    }
}   








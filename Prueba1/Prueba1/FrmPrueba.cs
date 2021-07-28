using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class FrmPrueba : Form
    {
        string primerVariable = "Hola Leandro, ";

        public FrmPrueba()
        {
            string SegundaVariable = "Haga un click en (ACEPTAR)";
            InitializeComponent();
            lblSaludo.Text = primerVariable + SegundaVariable;
            
        }

        private void FrmPrueba_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string tercerVariable = "Ahora, click en salir...";

            lblSaludo.Text = "Hola " + tercerVariable;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblSaludo_Click(object sender, EventArgs e)
        {

        }
    }
}

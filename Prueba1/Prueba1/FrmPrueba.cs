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
        string primerVariable = "Leandro, ";

        public FrmPrueba()
        {
            string SegundaVariable = "Hola Leandro, como te va? - HACÉ UN CLICK EN EL BOTON (ACEPTAR)";
            InitializeComponent();
            lblSaludo.Text =  SegundaVariable; 
        }

        private void FrmPrueba_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string tercerVariable = "HA PRESIONADO EL BOTON ACEPTAR, Y ESTO HA OCASIONADO UN UN ERROR...";

            lblSaludo.Text = "Hola " + primerVariable + tercerVariable;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

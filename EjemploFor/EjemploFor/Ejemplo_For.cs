using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploFor
{
    public partial class Formulario_contador : Form
    {
        public Formulario_contador()
        {
            InitializeComponent();
        }

        private void Btnaceptar_Click(object sender, EventArgs e)
        {
            for (int i = System.Convert.ToInt32(txtDesde.Text); //Desde
                i < System.Convert.ToInt32(txtHasta.Text); // Hasta
                i = i + System.Convert.ToInt32(txtPaso.Text)) //Paso
            {
                LblRes.Text = i.ToString();
                this.Refresh();
            }
        }
    }
}

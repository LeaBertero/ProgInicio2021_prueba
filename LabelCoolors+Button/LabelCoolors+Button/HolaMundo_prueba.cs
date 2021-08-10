using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelCoolors_Button
{
    public partial class HolaMundo_prueba : Form
    {
        public HolaMundo_prueba()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRojo_Click(object sender, EventArgs e)
        {
            LblRojo.Text = "Soy verde";
        }

        private void BtnVerde_Click(object sender, EventArgs e)
        {
            LblVerde.Text = "Soy Rojo";
        }

        private void BtnMovRojo_Click(object sender, EventArgs e)
        {
            int AnchoFormulario = 0;
            AnchoFormulario = this.Width;
            int AnchoLabel = LblRojo.Width;
            int AnchoBorde = 10;
            int X = 0;
            int Paso = 1;

            while (X < AnchoFormulario - AnchoLabel - AnchoBorde)
            {
                LblRojo.Left = X;
                this.Refresh();
                X = X + Paso;
            }
        }
    }
}

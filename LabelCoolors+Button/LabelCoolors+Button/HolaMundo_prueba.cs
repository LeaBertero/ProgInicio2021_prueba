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
            this.LblRojo.Text = "El original, soy yo !!!";
        }

        private void BtnVerde_Click(object sender, EventArgs e)
        {
            this.LblVerde.Text = "Soy un rectángulo rojo...";
        }

        private void BtnMovRojo_Click(object sender, EventArgs e)
        {
            int AnchoFormulario = 0;
            AnchoFormulario = this.Width;
            int AnchoLabel = LblRojo.Width;
            int AnchoBorde = 85;
            int X = 0;
            int Paso = 5;

            while (X < AnchoFormulario - AnchoLabel - AnchoBorde)
            {
                this.LblRojo.Left = X;
                this.Refresh();
                X = X + Paso;
            }
        }

        private void LblVerde_Click(object sender, EventArgs e)
        {

        }

        private void LblRojo_Click(object sender, EventArgs e)
        {

        }

        private void BtnMovBlack_Click(object sender, EventArgs e)
        {
            int LargoFor = 0;
            LargoFor = this.Width;
            int AnchoLbl = LblMenBlack.Top;
            int AnchoLargo = 185;
            int L = 195;
            int Paso = 2;

            while (L < LargoFor - AnchoLbl - AnchoLargo)
            {
                this.LblMenBlack.Top = L;
                this.Refresh();
                L = L + Paso;
            }
        }
    }
}

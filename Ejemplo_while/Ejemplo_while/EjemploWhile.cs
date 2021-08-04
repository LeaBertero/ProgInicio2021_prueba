using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_while
{
    public partial class EjemploWhile : Form
    {
        public EjemploWhile()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int AnchoFormulario = 0;
            AnchoFormulario = this.Width;
            int AnchoLabel = LblMov.Width;
            int AnchoBorde = 15;

            
            for (int X = 0;  X < AnchoFormulario-AnchoLabel-AnchoBorde; X++)
            {
                LblMov.Left = X;

            }
        }

        private void EjemploWhile_Load(object sender, EventArgs e)
        {

        }
    }
}

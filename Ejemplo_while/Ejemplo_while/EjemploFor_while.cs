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
    public partial class EjemploFor_while : Form
    {
        public EjemploFor_while()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int AnchoFormulario = 0;
            AnchoFormulario = this.Width;
            int AnchoLabel = LblMov.Width;
            int AnchoBorde = 15;
            int X = 0;
            int paso = 1;


            //for (int X = 0; X < AnchoFormulario - AnchoLabel - AnchoBorde; X++)
            //{
            //    LblMov.Left = X;

            //}

            while (X < AnchoFormulario - AnchoLabel - AnchoBorde)
            {
                LblMov.Left = X;
                this.Refresh();
                X = X + paso; 
            }
        }

        private void EjemploWhile_Load(object sender, EventArgs e)
        {

        }
    }
}

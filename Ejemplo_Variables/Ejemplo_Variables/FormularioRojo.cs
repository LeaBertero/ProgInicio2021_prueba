using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Variables
{
    public partial class FrmRojo : Form
    {
        public FrmRojo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAzul_Click(object sender, EventArgs e)
        {
            Form FormularioBlue = new FrmAzul();
            FormularioBlue.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            int NumRest1 = System.Convert.ToInt16(TxtIng1.Text);
            int NumRest2 = System.Convert.ToInt16(TxtIng2.Text);

            decimal resultado = (NumRest1 - NumRest2);

            LblResult.Text = System.Convert.ToString(resultado);
        }
    }
}

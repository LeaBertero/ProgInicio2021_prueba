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
    public partial class FrmAzul : Form
    {
        public FrmAzul()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            decimal numero1 = System.Convert.ToDecimal(TxtNum1.Text);
            decimal numero2 = System.Convert.ToDecimal(TxtNum2.Text);

            decimal res = (numero1 + numero2);

            LblRes.Text = System.Convert.ToString(res);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormularioAzul_Load(object sender, EventArgs e)
        {

        }

        private void BtnRojo_Click(object sender, EventArgs e)
        {
            Form FormularioRed = new FrmRojo();
            FormularioRed.Show();
        }
    }
}

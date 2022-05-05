using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Conversion
{
    public partial class FrmConvert : Form
    {
        public FrmConvert()
        {
            InitializeComponent();
        }

        decimal oper1;
        decimal oper2;

        private void BtnRes_Click(object sender, EventArgs e)
        {
            //decimal oper1 = System.Convert.ToDecimal(TxtSum1.Text);
            //decimal oper2 = System.Convert.ToDecimal(TxtSum2.Text);

            oper1 = Convert.ToDecimal(TxtSum1.Text);
            oper2 = Convert.ToDecimal(TxtSum2.Text);

            decimal res = oper1 + oper2;
            LblRes.Text = System.Convert.ToString(res);
        }
    }
}

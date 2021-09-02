using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            int resultado;

            numero1 = System.Convert.ToInt32(textBox1.Text);
            numero2 = System.Convert.ToInt32(textBox2.Text);

            resultado = numero1 + numero2;

            LblRes.Text = System.Convert.ToString(resultado);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaIff2
{
    public partial class FormularioEdad : Form
    {
        public FormularioEdad()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int edad = System.Convert.ToInt32(TxtEdad.Text);

            if (edad <= 12)
            {
                lblRes.Text = "Esta persona, es un niño";
            }
            else if (edad >= 15 && edad < 20)
            {
                lblRes.Text = "esta persona, es un adolescente";
            }
            if (edad >= 21)
            {
                lblRes.Text = "Esta persona, es un adulto";
            }
            if (edad >= 50)
            {
                lblRes.Text = "Esta persona es un adulto mayor";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Swich
{
    public partial class Switch_arranque : Form
    {
        public Switch_arranque()
        {
            InitializeComponent();
        }

        private void Swuich_arranque_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int edad = System.Convert.ToInt32 (TxtEdad.Text);

            switch (edad)
            {
                case 10:
                    LblRes.Text = "Es Menor de edad";
                    break;
                case 21:
                LblRes.Text = "Es Mayor de edad";
                    break;
                case 40:
                    LblRes.Text = "Es un adulto";
                    break;
                case 60:
                    LblRes.Text = "Es un adulto Mayor";
                    break;

            }
        }
    }
}

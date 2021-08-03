using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Switch__Segunda_parte_
{
    public partial class Switch_arranque : Form
    {
        public Switch_arranque()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int nota = System.Convert.ToInt32(TxtNota.Text);

            switch (TxtNota.Text.Trim())
            {
                case "1":
                    LblRes.Text = "Aplazado";
                    break;
                case "2":
                    LblRes.Text = "Aplazado";
                    break;
                case "3":
                    LblRes.Text = "Aprobado";
                    break;
                case "4":
                    LblRes.Text = "Promocionado";
                    break;
                case "5":
                    LblRes.Text = "Promocionado";
                    break;
                default:
                    LblRes.Text = "Nota no valida";
                    break;
            }
        }
        
        private void Switch_arranque_Load(object sender, EventArgs e)
        {

        }
    }
}

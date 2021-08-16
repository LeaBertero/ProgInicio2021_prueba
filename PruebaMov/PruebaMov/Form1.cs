using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaMov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtmMover_Click(object sender, EventArgs e)
        {
            int anchofor = 0;
            anchofor = this.Width;
            int ancholabel = Lbldez.Width;
            int anchoborde = 70;
            int X = 0;
            int paso = 1;

            while (X < anchofor - ancholabel - anchoborde)
            {
                this.Lbldez.Left = X;
                this.Refresh();
                X = X + paso;
            }
        }

        private void Lbldez_Click(object sender, EventArgs e)
        {

        }
    }
}

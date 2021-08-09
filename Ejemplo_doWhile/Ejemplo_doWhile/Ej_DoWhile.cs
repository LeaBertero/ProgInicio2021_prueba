using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_doWhile
{
    public partial class Ej_DoWhile : Form
    {
        public Ej_DoWhile()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int AnchoFormulario;
            int AnchoLabel;
            int AnchoBorde;
            int X;
            int Paso;
            int Repeticion = 0;
            int TotalRepeticion = 5;

            do
            {
                AnchoFormulario = this.Width;
                AnchoLabel = LblDes.Width;
                AnchoBorde = 20;
                X = 0;
                Paso = 1;
                Repeticion = Repeticion + 1;

                while (X < AnchoFormulario - AnchoBorde - AnchoLabel)
                {
                    LblDes.Left = X;
                    this.Refresh();
                    X = X + Paso;
                }
            } while (Repeticion < TotalRepeticion);

}   }   } 

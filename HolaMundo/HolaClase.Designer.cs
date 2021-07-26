
namespace HolaMundo
{
    partial class HolaClase
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.LblEtiqueta = new System.Windows.Forms.Label();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.TxtMateria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(87, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblEtiqueta
            // 
            this.LblEtiqueta.AutoSize = true;
            this.LblEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEtiqueta.Location = new System.Drawing.Point(83, 36);
            this.LblEtiqueta.Name = "LblEtiqueta";
            this.LblEtiqueta.Size = new System.Drawing.Size(140, 20);
            this.LblEtiqueta.TabIndex = 1;
            this.LblEtiqueta.Text = "Ingrese materia:";
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.Location = new System.Drawing.Point(84, 199);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(46, 20);
            this.LblMensaje.TabIndex = 2;
            this.LblMensaje.Text = "Hola";
            // 
            // TxtMateria
            // 
            this.TxtMateria.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMateria.ForeColor = System.Drawing.Color.Red;
            this.TxtMateria.Location = new System.Drawing.Point(87, 78);
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.Size = new System.Drawing.Size(163, 29);
            this.TxtMateria.TabIndex = 3;
            // 
            // HolaClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(441, 275);
            this.Controls.Add(this.TxtMateria);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.LblEtiqueta);
            this.Controls.Add(this.button1);
            this.Name = "HolaClase";
            this.Text = "Hola Mundo - Primer Programa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblEtiqueta;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.TextBox TxtMateria;
    }
}



namespace MovimientoDeRectangulos
{
    partial class FrmDesplazamiento
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
            this.BtnBlanco = new System.Windows.Forms.Button();
            this.BtnNegro = new System.Windows.Forms.Button();
            this.LblBlanco = new System.Windows.Forms.Label();
            this.LblNegro = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBlanco
            // 
            this.BtnBlanco.Location = new System.Drawing.Point(3, 179);
            this.BtnBlanco.Name = "BtnBlanco";
            this.BtnBlanco.Size = new System.Drawing.Size(128, 39);
            this.BtnBlanco.TabIndex = 0;
            this.BtnBlanco.Text = "Iniciar Blanco";
            this.BtnBlanco.UseVisualStyleBackColor = true;
            this.BtnBlanco.Click += new System.EventHandler(this.BtnBlanco_Click);
            // 
            // BtnNegro
            // 
            this.BtnNegro.Location = new System.Drawing.Point(437, 0);
            this.BtnNegro.Name = "BtnNegro";
            this.BtnNegro.Size = new System.Drawing.Size(128, 39);
            this.BtnNegro.TabIndex = 1;
            this.BtnNegro.Text = "Iniciar Negro";
            this.BtnNegro.UseVisualStyleBackColor = true;
            this.BtnNegro.Click += new System.EventHandler(this.BtnNegro_Click);
            // 
            // LblBlanco
            // 
            this.LblBlanco.BackColor = System.Drawing.Color.White;
            this.LblBlanco.Location = new System.Drawing.Point(0, 233);
            this.LblBlanco.Name = "LblBlanco";
            this.LblBlanco.Size = new System.Drawing.Size(169, 42);
            this.LblBlanco.TabIndex = 2;
            // 
            // LblNegro
            // 
            this.LblNegro.BackColor = System.Drawing.SystemColors.InfoText;
            this.LblNegro.Location = new System.Drawing.Point(382, 0);
            this.LblNegro.Name = "LblNegro";
            this.LblNegro.Size = new System.Drawing.Size(49, 161);
            this.LblNegro.TabIndex = 3;
            this.LblNegro.ForeColorChanged += new System.EventHandler(this.BtnNegro_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(696, 399);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(92, 39);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Cerar";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmDesplazamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LblBlanco);
            this.Controls.Add(this.LblNegro);
            this.Controls.Add(this.BtnNegro);
            this.Controls.Add(this.BtnBlanco);
            this.Name = "FrmDesplazamiento";
            this.Opacity = 0.8D;
            this.Text = "Movimiento de 2 Label";
            this.Load += new System.EventHandler(this.FrmDesplazamiento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBlanco;
        private System.Windows.Forms.Button BtnNegro;
        private System.Windows.Forms.Label LblBlanco;
        private System.Windows.Forms.Label LblNegro;
        private System.Windows.Forms.Button BtnSalir;
    }
}


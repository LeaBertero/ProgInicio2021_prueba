
namespace Ejemplo_Conversion
{
    partial class FrmConvert
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
            this.sumador2 = new System.Windows.Forms.TextBox();
            this.Sumador1 = new System.Windows.Forms.TextBox();
            this.BtnRes = new System.Windows.Forms.Button();
            this.LblSumador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sumador2
            // 
            this.sumador2.Location = new System.Drawing.Point(324, 92);
            this.sumador2.Name = "sumador2";
            this.sumador2.Size = new System.Drawing.Size(100, 20);
            this.sumador2.TabIndex = 0;
            // 
            // Sumador1
            // 
            this.Sumador1.Location = new System.Drawing.Point(87, 92);
            this.Sumador1.Name = "Sumador1";
            this.Sumador1.Size = new System.Drawing.Size(100, 20);
            this.Sumador1.TabIndex = 1;
            // 
            // BtnRes
            // 
            this.BtnRes.BackColor = System.Drawing.Color.Black;
            this.BtnRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRes.Location = new System.Drawing.Point(494, 82);
            this.BtnRes.Name = "BtnRes";
            this.BtnRes.Size = new System.Drawing.Size(80, 34);
            this.BtnRes.TabIndex = 2;
            this.BtnRes.Text = "=";
            this.BtnRes.UseVisualStyleBackColor = false;
            // 
            // LblSumador
            // 
            this.LblSumador.AutoSize = true;
            this.LblSumador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSumador.Location = new System.Drawing.Point(256, 92);
            this.LblSumador.Name = "LblSumador";
            this.LblSumador.Size = new System.Drawing.Size(19, 20);
            this.LblSumador.TabIndex = 3;
            this.LblSumador.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Primer número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Segundo número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Igual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(614, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado";
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.Location = new System.Drawing.Point(629, 92);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(0, 20);
            this.LblRes.TabIndex = 8;
            // 
            // FrmConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(734, 191);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblSumador);
            this.Controls.Add(this.BtnRes);
            this.Controls.Add(this.Sumador1);
            this.Controls.Add(this.sumador2);
            this.Name = "FrmConvert";
            this.Text = "Ejemplo_Conversion";
            this.Load += new System.EventHandler(this.FrmConvert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sumador2;
        private System.Windows.Forms.TextBox Sumador1;
        private System.Windows.Forms.Button BtnRes;
        private System.Windows.Forms.Label LblSumador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblRes;
    }
}



namespace EjemploFor
{
    partial class Formulario_contador
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.Btnaceptar = new System.Windows.Forms.Button();
            this.txtPaso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(187, 73);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 20);
            this.txtHasta.TabIndex = 3;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(29, 73);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 20);
            this.txtDesde.TabIndex = 4;
            // 
            // Btnaceptar
            // 
            this.Btnaceptar.BackColor = System.Drawing.Color.Yellow;
            this.Btnaceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnaceptar.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnaceptar.ForeColor = System.Drawing.Color.Red;
            this.Btnaceptar.Location = new System.Drawing.Point(503, 69);
            this.Btnaceptar.Name = "Btnaceptar";
            this.Btnaceptar.Size = new System.Drawing.Size(93, 27);
            this.Btnaceptar.TabIndex = 5;
            this.Btnaceptar.Text = "Contar";
            this.Btnaceptar.UseVisualStyleBackColor = false;
            this.Btnaceptar.Click += new System.EventHandler(this.Btnaceptar_Click);
            // 
            // txtPaso
            // 
            this.txtPaso.Location = new System.Drawing.Point(348, 73);
            this.txtPaso.Name = "txtPaso";
            this.txtPaso.Size = new System.Drawing.Size(100, 20);
            this.txtPaso.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Paso";
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.Location = new System.Drawing.Point(499, 130);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(0, 20);
            this.LblRes.TabIndex = 10;
            // 
            // Formulario_contador
            // 
            this.AcceptButton = this.Btnaceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(619, 159);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPaso);
            this.Controls.Add(this.Btnaceptar);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.label1);
            this.Name = "Formulario_contador";
            this.Text = "EjemploFor (Para)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Button Btnaceptar;
        private System.Windows.Forms.TextBox txtPaso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblRes;
    }
}


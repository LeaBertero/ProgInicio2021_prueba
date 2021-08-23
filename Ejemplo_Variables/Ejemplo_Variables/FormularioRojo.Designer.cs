
namespace Ejemplo_Variables
{
    partial class FrmRojo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAzul = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnResult = new System.Windows.Forms.Button();
            this.TxtIng1 = new System.Windows.Forms.TextBox();
            this.TxtIng2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAzul
            // 
            this.BtnAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAzul.Location = new System.Drawing.Point(12, 12);
            this.BtnAzul.Name = "BtnAzul";
            this.BtnAzul.Size = new System.Drawing.Size(234, 43);
            this.BtnAzul.TabIndex = 0;
            this.BtnAzul.Text = "Nuevo Form. Azul";
            this.BtnAzul.UseVisualStyleBackColor = true;
            this.BtnAzul.Click += new System.EventHandler(this.BtnAzul_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(646, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnResult
            // 
            this.BtnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResult.Location = new System.Drawing.Point(446, 129);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(91, 34);
            this.BtnResult.TabIndex = 2;
            this.BtnResult.Text = "=";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // TxtIng1
            // 
            this.TxtIng1.Location = new System.Drawing.Point(105, 138);
            this.TxtIng1.Name = "TxtIng1";
            this.TxtIng1.Size = new System.Drawing.Size(100, 20);
            this.TxtIng1.TabIndex = 3;
            // 
            // TxtIng2
            // 
            this.TxtIng2.Location = new System.Drawing.Point(273, 139);
            this.TxtIng2.Name = "TxtIng2";
            this.TxtIng2.Size = new System.Drawing.Size(100, 20);
            this.TxtIng2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "-";
            // 
            // LblResult
            // 
            this.LblResult.BackColor = System.Drawing.Color.AliceBlue;
            this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.Location = new System.Drawing.Point(607, 136);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(100, 23);
            this.LblResult.TabIndex = 6;
            this.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmRojo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(753, 236);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtIng2);
            this.Controls.Add(this.TxtIng1);
            this.Controls.Add(this.BtnResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAzul);
            this.Name = "FrmRojo";
            this.Text = "Rojo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAzul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnResult;
        private System.Windows.Forms.TextBox TxtIng1;
        private System.Windows.Forms.TextBox TxtIng2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblResult;
    }
}
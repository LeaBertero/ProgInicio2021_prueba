
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
            this.SuspendLayout();
            // 
            // BtnAzul
            // 
            this.BtnAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAzul.Location = new System.Drawing.Point(405, 12);
            this.BtnAzul.Name = "BtnAzul";
            this.BtnAzul.Size = new System.Drawing.Size(234, 43);
            this.BtnAzul.TabIndex = 0;
            this.BtnAzul.Text = "Formulario Azul";
            this.BtnAzul.UseVisualStyleBackColor = true;
            this.BtnAzul.Click += new System.EventHandler(this.BtnAzul_Click);
            // 
            // FrmRojo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(651, 357);
            this.Controls.Add(this.BtnAzul);
            this.Name = "FrmRojo";
            this.Text = "Rojo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAzul;
    }
}
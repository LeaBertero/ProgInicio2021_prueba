
namespace PruebaMov
{
    partial class Form1
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
            this.BtmMover = new System.Windows.Forms.Button();
            this.Lbldez = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtmMover
            // 
            this.BtmMover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtmMover.Location = new System.Drawing.Point(50, 246);
            this.BtmMover.Name = "BtmMover";
            this.BtmMover.Size = new System.Drawing.Size(106, 42);
            this.BtmMover.TabIndex = 0;
            this.BtmMover.Text = "Comenzar";
            this.BtmMover.UseVisualStyleBackColor = true;
            this.BtmMover.Click += new System.EventHandler(this.BtmMover_Click);
            // 
            // Lbldez
            // 
            this.Lbldez.BackColor = System.Drawing.Color.Chartreuse;
            this.Lbldez.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbldez.Location = new System.Drawing.Point(0, 104);
            this.Lbldez.Name = "Lbldez";
            this.Lbldez.Size = new System.Drawing.Size(227, 95);
            this.Lbldez.TabIndex = 1;
            this.Lbldez.Text = "Coca Cola";
            this.Lbldez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbldez.Click += new System.EventHandler(this.Lbldez_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1070, 344);
            this.Controls.Add(this.Lbldez);
            this.Controls.Add(this.BtmMover);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtmMover;
        private System.Windows.Forms.Label Lbldez;
    }
}



namespace LabelCoolors_Button
{
    partial class HolaMundo_prueba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HolaMundo_prueba));
            this.BtnRojo = new System.Windows.Forms.Button();
            this.BtnVerde = new System.Windows.Forms.Button();
            this.LblRojo = new System.Windows.Forms.Label();
            this.LblVerde = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRojo
            // 
            this.BtnRojo.BackColor = System.Drawing.Color.Orange;
            this.BtnRojo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRojo.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRojo.Location = new System.Drawing.Point(308, 12);
            this.BtnRojo.Name = "BtnRojo";
            this.BtnRojo.Size = new System.Drawing.Size(111, 39);
            this.BtnRojo.TabIndex = 0;
            this.BtnRojo.Text = "Iniciar  rojo";
            this.BtnRojo.UseVisualStyleBackColor = false;
            this.BtnRojo.Click += new System.EventHandler(this.BtnRojo_Click);
            // 
            // BtnVerde
            // 
            this.BtnVerde.BackColor = System.Drawing.Color.Orange;
            this.BtnVerde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerde.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerde.Location = new System.Drawing.Point(32, 12);
            this.BtnVerde.Name = "BtnVerde";
            this.BtnVerde.Size = new System.Drawing.Size(120, 39);
            this.BtnVerde.TabIndex = 1;
            this.BtnVerde.Text = "Iniciar verde";
            this.BtnVerde.UseVisualStyleBackColor = false;
            this.BtnVerde.Click += new System.EventHandler(this.BtnVerde_Click);
            // 
            // LblRojo
            // 
            this.LblRojo.BackColor = System.Drawing.Color.Red;
            this.LblRojo.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRojo.ForeColor = System.Drawing.Color.White;
            this.LblRojo.Location = new System.Drawing.Point(29, 70);
            this.LblRojo.Name = "LblRojo";
            this.LblRojo.Size = new System.Drawing.Size(114, 51);
            this.LblRojo.TabIndex = 2;
            this.LblRojo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblVerde
            // 
            this.LblVerde.BackColor = System.Drawing.Color.Green;
            this.LblVerde.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVerde.ForeColor = System.Drawing.Color.White;
            this.LblVerde.Location = new System.Drawing.Point(305, 70);
            this.LblVerde.Name = "LblVerde";
            this.LblVerde.Size = new System.Drawing.Size(123, 51);
            this.LblVerde.TabIndex = 3;
            this.LblVerde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(185, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // HolaMundo_prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(451, 167);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LblVerde);
            this.Controls.Add(this.LblRojo);
            this.Controls.Add(this.BtnVerde);
            this.Controls.Add(this.BtnRojo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HolaMundo_prueba";
            this.Text = "Hola Mundo_prueba";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRojo;
        private System.Windows.Forms.Button BtnVerde;
        private System.Windows.Forms.Label LblRojo;
        private System.Windows.Forms.Label LblVerde;
        private System.Windows.Forms.Button button3;
    }
}


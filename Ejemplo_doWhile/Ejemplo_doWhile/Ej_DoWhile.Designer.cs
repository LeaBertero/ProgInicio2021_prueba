
namespace Ejemplo_doWhile
{
    partial class Ej_DoWhile
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
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.LblDes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.Red;
            this.BtnAceptar.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(131, 12);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(137, 47);
            this.BtnAceptar.TabIndex = 0;
            this.BtnAceptar.Text = "Comenzar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // LblDes
            // 
            this.LblDes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LblDes.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDes.ImageKey = "(ninguno)";
            this.LblDes.Location = new System.Drawing.Point(0, 87);
            this.LblDes.Name = "LblDes";
            this.LblDes.Size = new System.Drawing.Size(258, 46);
            this.LblDes.TabIndex = 1;
            this.LblDes.Text = "Mirá como se mueve !! =)";
            this.LblDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ej_DoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(674, 246);
            this.Controls.Add(this.LblDes);
            this.Controls.Add(this.BtnAceptar);
            this.Name = "Ej_DoWhile";
            this.Text = "Ejemplo Do While";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblDes;
    }
}


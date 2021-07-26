
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HolaClase));
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.LblEtiqueta = new System.Windows.Forms.Label();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.TxtMateria = new System.Windows.Forms.TextBox();
            this.lbletiqueta2 = new System.Windows.Forms.Label();
            this.TxtSalida2 = new System.Windows.Forms.TextBox();
            this.btnaceptar2 = new System.Windows.Forms.Button();
            this.lblmensaje2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAceptar.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnAceptar.Location = new System.Drawing.Point(16, 105);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(105, 45);
            this.BtnAceptar.TabIndex = 0;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblEtiqueta
            // 
            this.LblEtiqueta.AutoSize = true;
            this.LblEtiqueta.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.LblEtiqueta.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblEtiqueta.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEtiqueta.ForeColor = System.Drawing.Color.White;
            this.LblEtiqueta.Location = new System.Drawing.Point(12, 9);
            this.LblEtiqueta.Name = "LblEtiqueta";
            this.LblEtiqueta.Size = new System.Drawing.Size(151, 23);
            this.LblEtiqueta.TabIndex = 1;
            this.LblEtiqueta.Text = "Ingrese materia:";
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.BackColor = System.Drawing.Color.White;
            this.LblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.ForeColor = System.Drawing.Color.Red;
            this.LblMensaje.Location = new System.Drawing.Point(12, 179);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(46, 20);
            this.LblMensaje.TabIndex = 2;
            this.LblMensaje.Text = "Hola";
            // 
            // TxtMateria
            // 
            this.TxtMateria.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMateria.ForeColor = System.Drawing.Color.Red;
            this.TxtMateria.Location = new System.Drawing.Point(12, 57);
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.Size = new System.Drawing.Size(219, 29);
            this.TxtMateria.TabIndex = 3;
            // 
            // lbletiqueta2
            // 
            this.lbletiqueta2.AutoSize = true;
            this.lbletiqueta2.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbletiqueta2.Location = new System.Drawing.Point(8, 218);
            this.lbletiqueta2.Name = "lbletiqueta2";
            this.lbletiqueta2.Size = new System.Drawing.Size(145, 23);
            this.lbletiqueta2.TabIndex = 4;
            this.lbletiqueta2.Text = "¿Usted aprobó?";
            // 
            // TxtSalida2
            // 
            this.TxtSalida2.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalida2.ForeColor = System.Drawing.Color.Red;
            this.TxtSalida2.Location = new System.Drawing.Point(12, 244);
            this.TxtSalida2.Name = "TxtSalida2";
            this.TxtSalida2.Size = new System.Drawing.Size(219, 29);
            this.TxtSalida2.TabIndex = 5;
            // 
            // btnaceptar2
            // 
            this.btnaceptar2.BackColor = System.Drawing.Color.Black;
            this.btnaceptar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaceptar2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar2.ForeColor = System.Drawing.Color.Red;
            this.btnaceptar2.Location = new System.Drawing.Point(16, 279);
            this.btnaceptar2.Name = "btnaceptar2";
            this.btnaceptar2.Size = new System.Drawing.Size(105, 45);
            this.btnaceptar2.TabIndex = 6;
            this.btnaceptar2.Text = "Aceptar";
            this.btnaceptar2.UseVisualStyleBackColor = false;
            this.btnaceptar2.Click += new System.EventHandler(this.btnaceptar2_Click);
            // 
            // lblmensaje2
            // 
            this.lblmensaje2.AutoSize = true;
            this.lblmensaje2.BackColor = System.Drawing.Color.White;
            this.lblmensaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje2.ForeColor = System.Drawing.Color.Red;
            this.lblmensaje2.Location = new System.Drawing.Point(8, 360);
            this.lblmensaje2.Name = "lblmensaje2";
            this.lblmensaje2.Size = new System.Drawing.Size(0, 20);
            this.lblmensaje2.TabIndex = 7;
            // 
            // HolaClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(378, 435);
            this.Controls.Add(this.lblmensaje2);
            this.Controls.Add(this.btnaceptar2);
            this.Controls.Add(this.TxtSalida2);
            this.Controls.Add(this.lbletiqueta2);
            this.Controls.Add(this.TxtMateria);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.LblEtiqueta);
            this.Controls.Add(this.BtnAceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HolaClase";
            this.Text = "Hola Mundo - Primer Programa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblEtiqueta;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.TextBox TxtMateria;
        private System.Windows.Forms.Label lbletiqueta2;
        private System.Windows.Forms.TextBox TxtSalida2;
        private System.Windows.Forms.Button btnaceptar2;
        private System.Windows.Forms.Label lblmensaje2;
    }
}


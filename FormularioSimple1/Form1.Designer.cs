namespace FormularioSimple1
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
            this.btnValidar = new System.Windows.Forms.Button();
            this.txtSegundaContrasena = new System.Windows.Forms.TextBox();
            this.txtPrimeraContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(306, 121);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(201, 41);
            this.btnValidar.TabIndex = 0;
            this.btnValidar.Text = "VALIDAR";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // txtSegundaContrasena
            // 
            this.txtSegundaContrasena.Location = new System.Drawing.Point(306, 76);
            this.txtSegundaContrasena.Name = "txtSegundaContrasena";
            this.txtSegundaContrasena.Size = new System.Drawing.Size(201, 20);
            this.txtSegundaContrasena.TabIndex = 1;
            // 
            // txtPrimeraContrasena
            // 
            this.txtPrimeraContrasena.Location = new System.Drawing.Point(306, 50);
            this.txtPrimeraContrasena.Name = "txtPrimeraContrasena";
            this.txtPrimeraContrasena.Size = new System.Drawing.Size(199, 20);
            this.txtPrimeraContrasena.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Repetir Contraseña";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 276);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrimeraContrasena);
            this.Controls.Add(this.txtSegundaContrasena);
            this.Controls.Add(this.btnValidar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.TextBox txtSegundaContrasena;
        private System.Windows.Forms.TextBox txtPrimeraContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


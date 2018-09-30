namespace Area_y_perimetro__Cuadrado__2 {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtlado2 = new System.Windows.Forms.TextBox();
            this.txtlado3 = new System.Windows.Forms.TextBox();
            this.txtlado4 = new System.Windows.Forms.TextBox();
            this.txtlado1 = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.txtperimetro = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(301, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 190);
            this.panel1.TabIndex = 0;
            // 
            // txtlado2
            // 
            this.txtlado2.Enabled = false;
            this.txtlado2.Location = new System.Drawing.Point(526, 198);
            this.txtlado2.Name = "txtlado2";
            this.txtlado2.Size = new System.Drawing.Size(20, 20);
            this.txtlado2.TabIndex = 1;
            // 
            // txtlado3
            // 
            this.txtlado3.Enabled = false;
            this.txtlado3.Location = new System.Drawing.Point(386, 79);
            this.txtlado3.Name = "txtlado3";
            this.txtlado3.Size = new System.Drawing.Size(20, 20);
            this.txtlado3.TabIndex = 2;
            // 
            // txtlado4
            // 
            this.txtlado4.Enabled = false;
            this.txtlado4.Location = new System.Drawing.Point(243, 198);
            this.txtlado4.Name = "txtlado4";
            this.txtlado4.Size = new System.Drawing.Size(20, 20);
            this.txtlado4.TabIndex = 3;
            // 
            // txtlado1
            // 
            this.txtlado1.Location = new System.Drawing.Point(386, 342);
            this.txtlado1.Name = "txtlado1";
            this.txtlado1.Size = new System.Drawing.Size(20, 20);
            this.txtlado1.TabIndex = 4;
            // 
            // txtarea
            // 
            this.txtarea.Enabled = false;
            this.txtarea.Location = new System.Drawing.Point(37, 38);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(147, 20);
            this.txtarea.TabIndex = 5;
            // 
            // txtperimetro
            // 
            this.txtperimetro.Enabled = false;
            this.txtperimetro.Location = new System.Drawing.Point(37, 79);
            this.txtperimetro.Name = "txtperimetro";
            this.txtperimetro.Size = new System.Drawing.Size(147, 20);
            this.txtperimetro.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(321, 396);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(150, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtperimetro);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.txtlado1);
            this.Controls.Add(this.txtlado4);
            this.Controls.Add(this.txtlado3);
            this.Controls.Add(this.txtlado2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtlado2;
        private System.Windows.Forms.TextBox txtlado3;
        private System.Windows.Forms.TextBox txtlado4;
        private System.Windows.Forms.TextBox txtlado1;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.TextBox txtperimetro;
        private System.Windows.Forms.Button btnCalcular;
    }
}


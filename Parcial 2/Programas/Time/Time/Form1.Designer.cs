namespace Time {
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
            this.Salida = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.Button();
            this.nombres = new System.Windows.Forms.ComboBox();
            this.Entrada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Salida
            // 
            this.Salida.Location = new System.Drawing.Point(63, 114);
            this.Salida.Name = "Salida";
            this.Salida.Size = new System.Drawing.Size(75, 23);
            this.Salida.TabIndex = 0;
            this.Salida.Text = "Salida";
            this.Salida.UseVisualStyleBackColor = true;
            this.Salida.Click += new System.EventHandler(this.registro_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(243, 95);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(75, 23);
            this.Mostrar.TabIndex = 6;
            this.Mostrar.Text = "Mostrar Registro";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // nombres
            // 
            this.nombres.FormattingEnabled = true;
            this.nombres.Items.AddRange(new object[] {
            "Sergio",
            "Many",
            "Chatmajo",
            "Citrico",
            "Miguel"});
            this.nombres.Location = new System.Drawing.Point(31, 29);
            this.nombres.Name = "nombres";
            this.nombres.Size = new System.Drawing.Size(138, 21);
            this.nombres.TabIndex = 7;
            this.nombres.Text = "Selecciona tu nombre";
            this.nombres.SelectedIndexChanged += new System.EventHandler(this.nombres_SelectedIndexChanged);
            // 
            // Entrada
            // 
            this.Entrada.Location = new System.Drawing.Point(63, 70);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(75, 23);
            this.Entrada.TabIndex = 8;
            this.Entrada.Text = "Entrada";
            this.Entrada.UseVisualStyleBackColor = true;
            this.Entrada.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 166);
            this.Controls.Add(this.Entrada);
            this.Controls.Add(this.nombres);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.Salida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Salida;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.ComboBox nombres;
        private System.Windows.Forms.Button Entrada;
    }
}


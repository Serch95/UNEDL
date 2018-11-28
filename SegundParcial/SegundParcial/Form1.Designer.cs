namespace SegundParcial {
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
            this.Numeros = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.Button();
            this.EArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Numeros
            // 
            this.Numeros.Location = new System.Drawing.Point(67, 48);
            this.Numeros.Name = "Numeros";
            this.Numeros.Size = new System.Drawing.Size(167, 20);
            this.Numeros.TabIndex = 0;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(47, 92);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 1;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(100, 138);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(75, 23);
            this.Mostrar.TabIndex = 2;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // EArchivo
            // 
            this.EArchivo.Location = new System.Drawing.Point(157, 92);
            this.EArchivo.Name = "EArchivo";
            this.EArchivo.Size = new System.Drawing.Size(120, 23);
            this.EArchivo.TabIndex = 3;
            this.EArchivo.Text = "Escribir en archivo";
            this.EArchivo.UseVisualStyleBackColor = true;
            this.EArchivo.Click += new System.EventHandler(this.EArchivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EArchivo);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Numeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Numeros;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.Button EArchivo;
    }
}


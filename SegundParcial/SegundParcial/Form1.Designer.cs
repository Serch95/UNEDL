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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRuta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(109, 255);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(75, 23);
            this.btnRuta.TabIndex = 5;
            this.btnRuta.Text = "Agregar ruta";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Primero ingresa la ruta donde se va a crear el archivo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Label label1;
    }
}


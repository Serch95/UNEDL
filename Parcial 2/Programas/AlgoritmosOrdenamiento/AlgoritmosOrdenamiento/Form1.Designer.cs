using System;

namespace AlgoritmosOrdenamiento {
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
            this.label1 = new System.Windows.Forms.Label();
            this.Numeros = new System.Windows.Forms.TextBox();
            this.Bubble = new System.Windows.Forms.Button();
            this.Merge = new System.Windows.Forms.Button();
            this.heap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrdenados = new System.Windows.Forms.Label();
            this.txtMetodo = new System.Windows.Forms.Label();
            this.Quick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa separados por comas, los numeros que quieres ordenar";
            // 
            // Numeros
            // 
            this.Numeros.Location = new System.Drawing.Point(172, 68);
            this.Numeros.Name = "Numeros";
            this.Numeros.Size = new System.Drawing.Size(473, 20);
            this.Numeros.TabIndex = 1;
            // 
            // Bubble
            // 
            this.Bubble.Location = new System.Drawing.Point(462, 116);
            this.Bubble.Name = "Bubble";
            this.Bubble.Size = new System.Drawing.Size(75, 23);
            this.Bubble.TabIndex = 3;
            this.Bubble.Text = "Bubble Sort";
            this.Bubble.UseVisualStyleBackColor = true;
            this.Bubble.Click += new System.EventHandler(this.Bubble_Click);
            // 
            // Merge
            // 
            this.Merge.Location = new System.Drawing.Point(249, 182);
            this.Merge.Name = "Merge";
            this.Merge.Size = new System.Drawing.Size(75, 23);
            this.Merge.TabIndex = 4;
            this.Merge.Text = "Merge Sort";
            this.Merge.UseVisualStyleBackColor = true;
            this.Merge.Click += new System.EventHandler(this.Merge_Click);
            // 
            // heap
            // 
            this.heap.Location = new System.Drawing.Point(462, 182);
            this.heap.Name = "heap";
            this.heap.Size = new System.Drawing.Size(75, 23);
            this.heap.TabIndex = 5;
            this.heap.Text = "Heap Sort";
            this.heap.UseVisualStyleBackColor = true;
            this.heap.Click += new System.EventHandler(this.hearp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Los numeros ordenados con el metodo:  ";
            // 
            // txtOrdenados
            // 
            this.txtOrdenados.AutoSize = true;
            this.txtOrdenados.Location = new System.Drawing.Point(169, 360);
            this.txtOrdenados.Name = "txtOrdenados";
            this.txtOrdenados.Size = new System.Drawing.Size(0, 13);
            this.txtOrdenados.TabIndex = 7;
            // 
            // txtMetodo
            // 
            this.txtMetodo.AutoSize = true;
            this.txtMetodo.Location = new System.Drawing.Point(416, 298);
            this.txtMetodo.Name = "txtMetodo";
            this.txtMetodo.Size = new System.Drawing.Size(0, 13);
            this.txtMetodo.TabIndex = 8;
            // 
            // Quick
            // 
            this.Quick.Location = new System.Drawing.Point(249, 116);
            this.Quick.Name = "Quick";
            this.Quick.Size = new System.Drawing.Size(75, 23);
            this.Quick.TabIndex = 9;
            this.Quick.Text = "QuickSort";
            this.Quick.UseVisualStyleBackColor = true;
            this.Quick.Click += new System.EventHandler(this.Quick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Quick);
            this.Controls.Add(this.txtMetodo);
            this.Controls.Add(this.txtOrdenados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heap);
            this.Controls.Add(this.Merge);
            this.Controls.Add(this.Bubble);
            this.Controls.Add(this.Numeros);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

  

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Numeros;
        private System.Windows.Forms.Button Bubble;
        private System.Windows.Forms.Button Merge;
        private System.Windows.Forms.Button heap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtOrdenados;
        private System.Windows.Forms.Label txtMetodo;
        private System.Windows.Forms.Button Quick;
    }
}


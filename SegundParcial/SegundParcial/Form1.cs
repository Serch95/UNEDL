﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace SegundParcial {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            Agregar.Visible = false;
            Mostrar.Visible = false;
            EArchivo.Visible = false;
        }

        string rutaCompleta;
        List<int> lista = new List<int>();
        List<String> tiempo = new List<String>();

        public void ruta() {
            rutaCompleta = textBox1.Text;
            GenerarTXT();
        }
               
        void GenerarTXT() {
            bool flag = true;
            try {
                using (StreamWriter mylogs = File.AppendText(rutaCompleta)) {
                    mylogs.Close();
                }
            }catch (Exception ex) {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            if (flag) {
                Agregar.Visible = true;
                Mostrar.Visible = true;
                EArchivo.Visible = true;
            }
        }

        public String getFecha() {
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            var culture = new CultureInfo("es-MX");
            return dateTime.ToString(culture);
        }

        void EscribirArchivo() {
            try {
                using (StreamWriter file = new StreamWriter(rutaCompleta, true)) {
                    for (int i = 0; i < lista.Count; i++) {
                        file.Write(lista[i] + " - ");
                        file.WriteLine(tiempo[i]);
                    }
                    file.WriteLine();
                    file.Close();
                }
            }catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

}

        void MostrarArchivo() {
            string line = "";
            String message = "";
            try {


                using (StreamReader file = new StreamReader(rutaCompleta)) {
                    while ((line = file.ReadLine()) != null) {
                        message += line + "\n";
                    }
                    MessageBox.Show(message); ;

                    file.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Agregar_Click(object sender, EventArgs e) {
            try {
                lista.Add(Convert.ToInt32(Numeros.Text));
                tiempo.Add(getFecha());
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            Numeros.Text = "";
            MetodoBurbuja();

            void MetodoBurbuja() {
                int t;
                for (int a = 1; a < lista.Count; a++)
                    for (int b = lista.Count - 1; b >= a; b--) {
                        if (lista[b - 1] > lista[b]) {
                            t = lista[b - 1];
                            lista[b - 1] = lista[b];
                            lista[b] = t;
                        }
                    }
            }
        }

        private void Mostrar_Click(object sender, EventArgs e) {
            MostrarArchivo();
            for (int i = 0; i < lista.Count; i++) {
                MessageBox.Show(Convert.ToString(lista[i]));
            }

        }

        private void EArchivo_Click(object sender, EventArgs e) {
            EscribirArchivo();
        }

        private void btnRuta_Click(object sender, EventArgs e) {
            ruta();

        }
    }
}

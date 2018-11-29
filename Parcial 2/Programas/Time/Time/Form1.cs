using System;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;

namespace Time {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            GenerarTXT();
            test2();
        }

        public class Test {
            String nombre;
            bool estado;

            public Test(String nombre, bool estado) {
                this.nombre = nombre;
                this.estado = estado;
            }

            public string Nombre { get => nombre; set => nombre = value; }
            public bool Estado { get => estado; set => estado = value; }
        }

        public void test2() {
            registro.Add(new Test("Sergio", false));
            registro.Add(new Test("Many", false));
            registro.Add(new Test("Chatmajo", false));
            registro.Add(new Test("Citrico", false));
            registro.Add(new Test("Miguel", false));
        }

        string rutaCompleta = @" C:\Users\Sergio\source\repos\Parcial 2\Documentos\Registro.txt";
        DateTime dateTime = new DateTime();
        List<Test> registro = new List<Test>();


        public String getFecha() {
            dateTime = DateTime.Now;
            var culture = new CultureInfo("es-MX");
            return dateTime.ToString(culture);
        }

        void GenerarTXT() {
            using (StreamWriter mylogs = File.AppendText(rutaCompleta)) {

                mylogs.Close();
            }
        }

        void escribirEntrada() {
            String nombre = nombres.Text;
            for (int i = 0; i < 5; i++) {
                if (registro.ElementAt(i).Nombre == nombre) {
                    registro.ElementAt(i).Estado = true;
                }                
            }
            using (StreamWriter file = new StreamWriter(rutaCompleta, true)) {
                file.WriteLine(nombre + " , Entrada , " + getFecha());
                file.Close();
            }
            Salida.Visible = true;
            Entrada.Visible = false;
        }

        void escribirSalida() {
            String nombre = nombres.Text;
            using (StreamWriter file = new StreamWriter(rutaCompleta, true)) {
                file.WriteLine(nombre + " , Salida , " + getFecha());

                file.Close();
            }
            Salida.Visible = false;
            Entrada.Visible = true;
        }

        void leer() {
            string line = "";
            String message = "";
            using (StreamReader file = new StreamReader(rutaCompleta)) {
                while ((line = file.ReadLine()) != null) {
                    message += line + "\n";
                }
                MessageBox.Show(message); ;

                file.Close();
            }
        }

        private void registro_Click(object sender, EventArgs e) {
            escribirSalida();
        }

        private void Mostrar_Click(object sender, EventArgs e) {
            leer();
        }

        private void button1_Click(object sender, EventArgs e) {
            escribirEntrada();
        }

        private void nombres_SelectedIndexChanged(object sender, EventArgs e) {
            for (int i = 0; i < 5; i++) {
                if (nombres.Text == registro.ElementAt(i).Nombre) {
                    if (registro.ElementAt(i).Estado == true) {
                        Salida.Visible = true;
                        Entrada.Visible = false;
                    } else {
                        Salida.Visible = false;
                        Entrada.Visible = true;
                    }
                }
            }
        }
    }
}

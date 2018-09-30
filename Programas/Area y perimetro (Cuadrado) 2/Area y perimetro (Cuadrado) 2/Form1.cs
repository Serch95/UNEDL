using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_y_perimetro__Cuadrado__2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e) {

            try {
                String x = txtlado1.Text;                                
                int lado = Convert.ToInt32(x);

                if (lado != 0) {
                    int perimetro = Perimetro(lado);
                    int area = Area(lado);
                    txtlado2.Text = x;
                    txtlado3.Text = x;
                    txtlado4.Text = x;

                    txtarea.Text = "Area: " + area.ToString();
                    txtperimetro.Text = "Perimetro: " + perimetro.ToString();
                } else {
                    MessageBox.Show("Ingresa un valor diferente de 0");
                    txtlado1.Text = "";
                    txtlado2.Text = "";
                    txtlado3.Text = "";
                    txtlado4.Text = "";
                    txtarea.Text = "";
                    txtperimetro.Text = "";
                }
                
            } catch (Exception) {
                MessageBox.Show("Ingresa un valor valido");
                txtlado1.Text = "";
                txtlado2.Text = "";
                txtlado3.Text = "";
                txtlado4.Text = "";
                txtarea.Text = "";
                txtperimetro.Text = "";
            }
        }

        public int Perimetro(int lado) {
            int perimetro = lado * 4;
            return perimetro;
        }

        public int Area(int lado) {
            int area = lado * lado;
            return area;
        }
    }
}

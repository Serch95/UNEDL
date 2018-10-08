using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioCalificaciones {
    public partial class Form1 : Form {
        Random rnd = new Random();
        ArrayList list = new ArrayList(8);
        public Form1() {
            InitializeComponent();
            list.Add("Sergio");
            list.Add("Kevin");
            list.Add("Ivan");
            list.Add("Many");
            list.Add("Enrique");
            list.Add("Miguel");
            list.Add("Brian");
            list.Add("Octavio");
        }

        private void button2_Click(object sender, EventArgs e) {                        
            label1.Text = Convert.ToString(list[0]);
            label2.Text = Convert.ToString(list[1]);
            label3.Text = Convert.ToString(list[2]);
            label4.Text = Convert.ToString(list[3]);
            label5.Text = Convert.ToString(list[4]);
            label6.Text = Convert.ToString(list[5]);
            label7.Text = Convert.ToString(list[6]);
            label8.Text = Convert.ToString(list[7]);
            int calRandom = rnd.Next(50, 100);
            if (calRandom < 70) {
                textBox1.BackColor = Color.Red;
            } else {
                textBox1.BackColor = Color.Green;
            }
            textBox1.ForeColor = Color.White;
            textBox1.Text = Convert.ToString(calRandom);
            calRandom = rnd.Next(50, 100);
            if (calRandom < 70) {
                textBox2.BackColor = Color.Red;
            } else {
                textBox2.BackColor = Color.Green;
            }
            textBox2.ForeColor = Color.White;
            textBox2.Text = Convert.ToString(calRandom);
            calRandom = rnd.Next(50, 100);
            if (calRandom < 70) {
                textBox3.BackColor = Color.Red;
            } else {
                textBox3.BackColor = Color.Green;
            }
            textBox3.ForeColor = Color.White;
            textBox3.Text = Convert.ToString(calRandom);
            calRandom = rnd.Next(50, 100);
            if (calRandom < 70) {
                textBox4.BackColor = Color.Red;
            } else {
                textBox4.BackColor = Color.Green;
            }
            textBox4.ForeColor = Color.White;
            textBox4.Text = Convert.ToString(calRandom);
            calRandom = rnd.Next(50, 100);
            if (calRandom < 70) {
                textBox5.BackColor = Color.Red;
            } else {
                textBox5.BackColor = Color.Green;
            }
            textBox5.ForeColor = Color.White;
            textBox5.Text = Convert.ToString(calRandom);
            calRandom = rnd.Next(50, 100);
            if (calRandom < 70) {
                textBox6.BackColor = Color.Red;
            } else {
                textBox6.BackColor = Color.Green;
            }
            textBox6.ForeColor = Color.White;
            textBox6.Text = Convert.ToString(calRandom);
            calRandom = rnd.Next(50, 100);
            if (calRandom < 70) {
                textBox7.BackColor = Color.Red;
            } else {
                textBox7.BackColor = Color.Green;
            }
            textBox7.ForeColor = Color.White;
            textBox7.Text = Convert.ToString(calRandom);
            calRandom = rnd.Next(50, 100);
            if (calRandom < 70) {
                textBox8.BackColor = Color.Red;
            } else {
                textBox8.BackColor = Color.Green;
            }
            textBox8.ForeColor = Color.White;
            textBox8.Text = Convert.ToString(calRandom);
        }

        private void button1_Click(object sender, EventArgs e) {
            int cal1, cal2, cal3, cal4, cal5, cal6, cal7, cal8;
            float promedio;
            cal1 = Convert.ToInt32(textBox1.Text);
            cal2 = Convert.ToInt32(textBox2.Text);
            cal3 = Convert.ToInt32(textBox3.Text);
            cal4 = Convert.ToInt32(textBox4.Text);
            cal5 = Convert.ToInt32(textBox5.Text);
            cal6 = Convert.ToInt32(textBox6.Text);
            cal7 = Convert.ToInt32(textBox7.Text);
            cal8 = Convert.ToInt32(textBox8.Text);
            promedio = (cal1 + cal2 + cal3 + cal4 + cal5 + cal6 + cal7 + cal8) / 8;
            if (promedio < 70) {
                textBox9.BackColor = Color.Red;
                pictureBox1.Image = Image.FromFile(@"C:\Users\Sergio\Downloads\equis.png");

            } else {
                textBox9.BackColor = Color.Green;
                pictureBox1.Image = Image.FromFile(@"C:\Users\Sergio\Downloads\palomita.png");
            }
            textBox9.ForeColor = Color.White;
            textBox9.Text = Convert.ToString(promedio);
        }
    }
}

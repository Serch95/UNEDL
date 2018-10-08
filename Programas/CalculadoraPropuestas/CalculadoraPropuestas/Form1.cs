using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPropuestas {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e) {
            double Aguinaldo, Vacaciones, Prima, Infonavit, Imss, Rcv;
            double Sgmm, Sgmmd, Vales, Comedor, Seguro, Personal, Sick;
            double Saldo, Ley, Empresa, Total;
            Aguinaldo = (Convert.ToDouble(aguinaldo.Text) * (Convert.ToDouble(saldo1.Text))) / 100;
            Vacaciones = (Convert.ToDouble(vacaciones.Text) * (Convert.ToDouble(saldo1.Text))) / 100;
            Prima = (Convert.ToDouble(prima.Text) * (Convert.ToDouble(saldo1.Text))) / 100;
            Infonavit = (Convert.ToDouble(infonavit.Text) * (Convert.ToDouble(saldo1.Text))) / 100;
            Imss = (Convert.ToDouble(imss.Text) * (Convert.ToDouble(saldo1.Text))) / 100;
            Rcv = (Convert.ToDouble(rcv.Text) * (Convert.ToDouble(saldo1.Text))) / 100;
            Sgmm = (Convert.ToDouble(sgmm.Text) * (Convert.ToDouble(saldo1.Text))) / 100;
            Sgmmd = Sgmm * (Convert.ToDouble(dependents.Text));
            Vales = (Convert.ToDouble(vales.Text) * (Convert.ToDouble(saldo1.Text))) / 100;
            Comedor = Convert.ToDouble(comedor.Text);
            Seguro = Convert.ToDouble(seguro.Text);
            Personal = Convert.ToDouble(personal.Text);
            Sick = Convert.ToDouble(sick.Text);

            aguinaldo2.Text = Aguinaldo.ToString("C");
            vacaciones2.Text = Vacaciones.ToString("C");
            prima2.Text = Prima.ToString("C");
            infonavit2.Text = Infonavit.ToString("C");
            imss2.Text = Imss.ToString("C");
            rcv2.Text = Rcv.ToString("C");
            sgmm2.Text = Sgmm.ToString("C");
            sgmmd2.Text = Sgmmd.ToString("C");
            vales2.Text = Vales.ToString("C");
            comedor2.Text = Comedor.ToString("C");
            seguro2.Text = Seguro.ToString("C");
            personal2.Text = Personal.ToString("C");
            sick2.Text = Sick.ToString("C");

            Saldo = Convert.ToDouble(saldo1.Text);
            Ley = Aguinaldo + Vacaciones + Prima + Infonavit + Imss + Rcv;
            Empresa = Sgmm + Sgmmd + Vales + Comedor + Seguro + Personal + Sick; ;
            Total = Saldo + Empresa + Ley;

            saldo2.Text = Saldo.ToString("C");
            ley.Text = Ley.ToString("C");
            empresa.Text = Empresa.ToString("C");
            total.Text = Total.ToString("C");


        }
    }
}

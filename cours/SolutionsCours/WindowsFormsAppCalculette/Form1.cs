using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppCalculette.Model;
namespace WindowsFormsAppCalculette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            double ope1 = (double) nud_val1.Value;
            double ope2 = (double) nud_val2.Value;
            string ope = "+";
            double res = Calcul.Calculate(ope1, ope2, ope);
            lbl_res.Text = res.ToString();
        }

        private void btn_moins_Click(object sender, EventArgs e)
        {
            double ope1 = (double)nud_val1.Value;
            double ope2 = (double)nud_val2.Value;
            string ope = "-";
            double res = Calcul.Calculate(ope1, ope2, ope);
            lbl_res.Text = res.ToString();
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            double ope1 = (double)nud_val1.Value;
            double ope2 = (double)nud_val2.Value;
            string ope = "*";
            double res = Calcul.Calculate(ope1, ope2, ope);
            lbl_res.Text = res.ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            double ope1 = (double)nud_val1.Value;
            double ope2 = (double)nud_val2.Value;
            string ope = "/";
            double res = Calcul.Calculate(ope1, ope2, ope);
            lbl_res.Text = res.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace WindowsFormsPersonne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_appuyer_Click(object sender, EventArgs e)
        {
            string nom = txt_nom.Text;
            string prenom = txt_prenom.Text;
            int age = Convert.ToInt32(txt_age.Text);
            Personne p = new Personne(nom, prenom, age);
            lbl_recap.Text = p.ToString();
        }
    }
}

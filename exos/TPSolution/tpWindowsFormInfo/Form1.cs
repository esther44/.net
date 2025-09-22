using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpWindowsFormInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text.ToUpper();
            string prenom = textBox2.Text.ToLower();
            string ageText = textBox3.Text;

            if (!int.TryParse(ageText, out int age))
            {
                MessageBox.Show("Veuillez saisir un âge valide !");
                return;
            }

            string statut = age >= 18 ? "majeur" : "mineur";

            // Afficher le récap dans le label
            label1.Text = "Nom : " + nom + ", Prénom : " + prenom + ", Âge : " + age + " ans, Statut : " + statut;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

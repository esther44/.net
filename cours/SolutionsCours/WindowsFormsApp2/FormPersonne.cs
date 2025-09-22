using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2
{
    public partial class FormPersonne : Form
    {
        public FormPersonne()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            int age = Convert.ToInt32(textBoxAge.Text);
            Personne p = new Personne(nom, prenom, age);
            labelRecap.Text = p.ToString();
        }
    }
}

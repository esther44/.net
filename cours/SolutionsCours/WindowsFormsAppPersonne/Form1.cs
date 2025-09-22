using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPersonne.Model;

namespace WindowsFormsAppPersonne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_selectAll_Click(object sender, EventArgs e)
        {
            DaoPersonne dao = new DaoPersonne();
            List<Personne> liste = dao.SelectAll();

            foreach (Personne p in liste)
                lst_select.Items.Add(p.Id + "   " + p.Nom + "   " + p.Prenom + "   " + p.Age);
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            int age = Convert.ToInt32(txt_age.Text);
            string nom = txt_nom.Text;
            string prenom = txt_prenom.Text;

            Personne p = new Personne(id, nom, prenom, age);

            DaoPersonne dao = new DaoPersonne();
            dao.Insert(p);

        }
    }
}

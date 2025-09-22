using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppDaoArticle.Model;

namespace WindowsFormsAppDaoArticle
{
    public partial class insertForm : Form
    {
        public insertForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int reference = nud_ref.DecimalPlaces;
            string marque = txt_marque.Text;
            int prix = nud_prix.DecimalPlaces;

            Article a = new Article(reference, marque, prix);

            DaoArticle dao = new DaoArticle();
            dao.Insert(a);

            MessageBox.Show("Article inséré avec succès !");
        }
    }
}

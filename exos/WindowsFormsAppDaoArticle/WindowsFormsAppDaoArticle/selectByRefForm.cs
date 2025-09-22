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
    public partial class selectByRefForm : Form
    {
        public selectByRefForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int reference = (int)nud_ref.Value;

            DaoArticle dao = new DaoArticle();
            Article article = dao.SelectById(reference);

            if (article != null)
            {
                lbl_result.Text = article.ToString();
            }
            else
            {
                lbl_result.Text = "Aucun article trouvé pour cette référence.";
            }
        }
    }
}

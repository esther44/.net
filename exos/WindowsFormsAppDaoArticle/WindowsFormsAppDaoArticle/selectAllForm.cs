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
    public partial class selectAllForm : Form
    {
        public selectAllForm()
        {
            InitializeComponent();
        }

        private void selectAllForm_Load(object sender, EventArgs e)
        {
            DaoArticle dao = new DaoArticle();
            List<Article> articles = dao.SelectAll();

            listBox1.Items.Clear();
            foreach (var article in articles)
            {
                listBox1.Items.Add(article);
            }

        }
    }
}

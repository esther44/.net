using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDaoArticle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_selectAll_Click(object sender, EventArgs e)
        {
            selectAllForm form = new selectAllForm();
            form.Show();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            insertForm form = new insertForm();
            form.Show();
        }

        private void btn_selectByRef_Click(object sender, EventArgs e)
        {
            selectByRefForm form = new selectByRefForm();
            form.Show();
        }
    }
}

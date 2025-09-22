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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Article a = new Article(Convert.ToInt32(txt_reference.Text), txt_marque.Text, Convert.ToInt32(txt_prix.Text));
            lbl_result.Text = a.ToString();
        }
    }
}

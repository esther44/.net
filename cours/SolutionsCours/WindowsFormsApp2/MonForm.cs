using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MonForm : Form
    {
        public MonForm()
        {
            InitializeComponent();
        }

        private void MonForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void MonForm_DoubleClick(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void MonForm_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
    }
}

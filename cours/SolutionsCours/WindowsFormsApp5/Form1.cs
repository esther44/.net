using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Init_combo()
        {
            comboBox1.Items.Add("coca");
            comboBox1.Items.Add("fanta");
            comboBox1.Items.Add("sprite");
        }

        private void Init_ListBox()
        {
            listBox1.Items.Add("savane");
            listBox1.Items.Add("lu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            if (radioButton1.Checked)
            {
                label1.Text = "radio1";
            }
            else
            {
                label1.Text = "radio2";
            }

            label2.Text = "";
            if (checkBox1.Checked == true)
                label2.Text += "checkBox1 ok";
            if (checkBox2.Checked == true)
                label2.Text += "checkBox2 ok";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init_combo();
            Init_ListBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}

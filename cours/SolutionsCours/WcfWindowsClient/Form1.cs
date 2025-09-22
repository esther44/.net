using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfWindowsClient.NSService;
namespace WcfWindowsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1Client svc = new Service1Client();
            label1.Text = svc.DoWork();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service1Client svc = new Service1Client();
            label2.Text = svc.GetData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Service1Client svc = new Service1Client();
            svc.DoWorkAsync();

            svc.DoWorkCompleted += Svc_DoWorkCompleted;
        }

        private void Svc_DoWorkCompleted(object sender, DoWorkCompletedEventArgs e)
        {
            label3.Text = e.Result.ToString();
        }
    }
}

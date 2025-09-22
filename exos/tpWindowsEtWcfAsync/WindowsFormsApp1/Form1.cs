using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.NS1;
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
            Service1Client svc = new Service1Client();
            decimal result = svc.GetPrixTotal((int)nud_quantite.Value, (decimal)nud_prix.Value);
            label_total.Text = result.ToString();
            nud_ttc.Value = result;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service1Client svc = new Service1Client();
            svc.DoWorkAsync();

            svc.DoWorkCompleted += Svc_DoWorkCompleted;
        }

        private void Svc_DoWorkCompleted(object sender, DoWorkCompletedEventArgs e)
        {
            label_totalHT.Text = svc.GetPrixTotalHT(nud_ttc.Value).ToString();

        }
    }
}

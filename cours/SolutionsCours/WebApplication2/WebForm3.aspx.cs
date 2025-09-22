using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Model.Personne p = new Model.Personne(TextBox1.Text, TextBox2.Text, Convert.ToInt32(TextBox3.Text));
            Context.Items.Add("p", p);
            Context.Items.Add("nom", "toto");
            Server.Transfer("WebForm4.aspx");
        }
    }
}
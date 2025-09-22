using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tpWebForm1_ter.Model;

namespace tpWebForm1_ter
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Article a = new Article(TextBox1.Text, Convert.ToInt32(TextBox2.Text));
            Context.Items.Add("a", a);
            Server.Transfer("WebForm2.aspx");
        }
    }
}
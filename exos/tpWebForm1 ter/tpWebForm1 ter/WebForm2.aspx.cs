using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tpWebForm1_ter.Model;

namespace tpWebForm1_ter
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.Form["TextBox1"] + " " + Request.Form["TextBox2"];

            Article a = (Article)Context.Items["a"];
            Label2.Text = a.ToString();
        }
    }
}
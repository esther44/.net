using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Model;

namespace WebApplication2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(! IsPostBack)
            Label2.Text = Request.Form["TextBox1"].ToUpper() + "" + Request.Form["TextBox2"] + "" + Request.QueryString["lang"] + "" + Request.QueryString["nom"];

            Personne x = (Personne)Context.Items["p"];
            Label3.Text = x.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
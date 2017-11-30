using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                var cyka = File.ReadAllText(@"C:\beskeder.txt");
                if (cyka == string.Empty)
                {
                    Label1.Text = "der er ikke nogen beskeder";
                }
                else
                {
                    Label1.Text = cyka.Replace(Environment.NewLine, "<br />").Replace("__", "<hr />");
                }
            }
            catch(Exception I)
            {
                Label1.Text = ("fejl " + I);
            }

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("forum.aspx");
        }
    }
}
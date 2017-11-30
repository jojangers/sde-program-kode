using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication5
{
    public partial class forum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Reset_button_Click(object sender, EventArgs e)
        {
            string ConfirmValue = Request.Form["confirm_value"];
            if (ConfirmValue == "Yes")
            {
                Navn_textbox.Text = null;
                Mail_textbox.Text = null;
                Mobil_textbox.Text = null;
                Besked_textbox.Text = null;
                Adresse_textbox.Text = null;
                Label1.Text = "order 66 executed";
                Label1.Visible = true;
            }
            else
            {
                Label1.Text = "nice";
                Label1.Visible = true;
            }
        }

        protected void Logout_button_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Delete_all_button_Click(object sender, EventArgs e)
        {
            string ConfirmValue = Request.Form["confirm_value"];
            if (ConfirmValue == "Yes")
            {
                File.WriteAllText(@"C:\beskeder.txt", String.Empty);
                Navn_textbox.Text = null;
                Mail_textbox.Text = null;
                Mobil_textbox.Text = null;
                Besked_textbox.Text = null;
                Adresse_textbox.Text = null;
                Label1.Text = "beskederne er slettet";
                Label1.Visible = true;
            }
            else
            {
                Label1.Text = "beskederne er ikke slettet";
                Label1.Visible = true;
            }


        }

        protected void Save_button_Click(object sender, EventArgs e)
        {
            if (Mail_textbox != null && Navn_textbox != null && Besked_textbox != null && Adresse_textbox != null && Mobil_textbox != null)
            {
                Label1.Visible = false;
                StreamWriter saver = new StreamWriter(@"C:\beskeder.txt", true);
                saver.WriteLine("Navn: " + Navn_textbox.Text + Environment.NewLine);
                saver.WriteLine("Mail: " + Mail_textbox.Text + Environment.NewLine);
                saver.WriteLine("Besked: " + Besked_textbox.Text + Environment.NewLine);
                saver.WriteLine("Adresse: " + Adresse_textbox.Text + Environment.NewLine);
                saver.WriteLine("Mobil nummer: " + Mobil_textbox.Text + Environment.NewLine);
                saver.WriteLine("__" + Environment.NewLine);
                saver.Close();
            }
            else
            {
                Label1.Visible = true;
            }
        }

        protected void Read_all_button_Click(object sender, EventArgs e)
        {
            Response.Redirect("beskeder.aspx");
        }
    }
}
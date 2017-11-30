using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.IO;

namespace WebApplication5
{
    public partial class login : System.Web.UI.Page
    {
        static ArrayList navn = new ArrayList();
        static ArrayList mail = new ArrayList();
        static ArrayList pword = new ArrayList();
        static int login_attemptet = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Password_input.Text = "********";
            string line;
            bool Navnt = true;
            bool mailt = true;
            try //load brugernavne
            {
                StreamReader navnr = new StreamReader(path: @"C:\forum\navn.txt");
                line = navnr.ReadLine();
                if(line == null) //hvis der ikke er nogen brugernavne sæt navnt bool til false
                {
                    Navnt = false;
                }
                while (line != null)
                {
                    navn.Add(line);
                    line = navnr.ReadLine();
                }
                navnr.Close();
            }
            catch(Exception)//catch brugernavne import fejl
            {

            }




            try//load mails til login
            {
                StreamReader mailr = new StreamReader(path: @"C:\forum\mail.txt");
                line = mailr.ReadLine();
                if (line == null) //hvis der ikke er nogen mail logins, sæt mailt bool til false
                {
                    mailt = false;
                }
                while(line != null)
                {
                    mail.Add(line);
                    line = mailr.ReadLine();
                }
                mailr.Close();

            }
            catch(Exception)//catch mail import fejl
            {

            }
            if(Navnt == false && mailt == false) //hvis der ikke er nogen brugernavne eller mail addresser gå i panik
            {
                Login_error_label.Text = "wire user logins pls";
                Login_error_label.Visible = true;
                Register_Button.Visible = false;
                Login_Button.Visible = false;
            }
            else //hvis vi har mail, username eller begge, import passwords
            {
                try //import passwords
                {
                    StreamReader passr = new StreamReader(path: @"C:\forum\pword.txt");
                    line = passr.ReadLine();
                    while (line != null)
                    {
                        pword.Add(line);
                        line = passr.ReadLine();
                    }
                    passr.Close();
                }
                catch(Exception) //fang fejl fra password import
                {

                }
            }
            

        }

        protected void Login_Button_Click(object sender, EventArgs e)
        {
            string pas = Password_input.Text;
            string unam = Username_input.Text;
            if(pas == null || unam == null) //hvis brugeren ikke har skrevet et password eller brugernavn, spil russisk hardbass
            {
                Login_error_label.Text = "husk at skrive et password og username";
                Login_error_label.Visible = true;
            }
            foreach(string passu in pword) //kig igennem alle gemte passwords og sammenlign
            {
                if(pas == passu) //hvis et af passwordene matcher check brugernave og emails
                {
                    foreach(string namep in navn) //chek brugernavne
                    {
                        if(unam == namep) //hvis input er lig med en af de gemte passwords
                        {
                            Response.Redirect("forum.aspx");
                        }
                    }
                    foreach(string mailpp in mail) //check mails
                    {
                        if(mailpp == unam) //hvis input er lig med en af de gemte mails
                        {
                            Response.Redirect("forum.aspx");
                        }
                    }

                }


            }

            Login_error_label.Text = "forkert brugernavn eller kodeord, prøv igen";
            Login_error_label.Visible = true;
            login_attemptet++;
            if(login_attemptet >= 5)
            {
                //Login_Button.Visible = false;
                Login_error_label.Text = "du har for mange fejlede forsøg, lav en ny bruger";
            }

        }
    }
}
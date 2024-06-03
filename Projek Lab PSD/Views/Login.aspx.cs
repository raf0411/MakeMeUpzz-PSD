using Projek_Lab_PSD.Models;
using Projek_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projek_Lab_PSD.Views
{
    public partial class Login : System.Web.UI.Page
    {
        private MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            String username = UsernameTB.Text;
            String password = PasswordTB.Text;
            bool isRemember = rememberMeCheck.Checked;

            var user = (from x in db.Users 
                        where x.Username.Equals(username) && x.UserPassword.Equals(password) 
                        select x)
                        .FirstOrDefault();

            ErrorLbl.ForeColor = System.Drawing.Color.Red;

            if (user != null)
            {
                Session["user"] = user;

                ErrorLbl.Text = "User Login Successfully!";
                ErrorLbl.ForeColor = System.Drawing.Color.Green;

                if (isRemember)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = user.UserID.ToString();
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }

                if (Application["user_count"] == null)
                {
                    Application["user_count"] = 1;
                }
                else
                {
                    Application["user_count"] = ((int)Application["user_count"] + 1);
                }

                Response.Redirect("~/Views/Home.aspx");
            }
            else if (username == "")
            {
                ErrorLbl.Text = "Username may not be empty!";
            }
            else if (password == "")
            {
                ErrorLbl.Text = "Password may not be empty!";
            }
            else if (rememberMeCheck.Checked)
            {
                // TODO
            }
            else if(user == null)
            {
                ErrorLbl.Text = "User does not exists!";
            }
        }
    }
}
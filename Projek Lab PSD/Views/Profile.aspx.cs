using Projek_Lab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projek_Lab_PSD.Views
{
    public partial class Profile : System.Web.UI.Page
    {
        User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                user = (User)Session["user"]; ;

                DisplayProfile(user);
            }
        }

        public void DisplayProfile(User user)
        {
            Username.Text = user.Username;
            Email.Text = user.UserEmail;
            Gender.Text = user.UserGender;
            DOB.Text = user.UserDOB.ToString("dd/MM/yyyy");
        }

        protected void UpdateProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/UpdateProfile.aspx");
        }

        protected void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ChangePassword.aspx");
        }
    }
}
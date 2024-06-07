using Projek_Lab_PSD.Controllers;
using Projek_Lab_PSD.Handlers;
using Projek_Lab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projek_Lab_PSD.Views
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        User user;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                user = (User)Session["user"]; ;

                if (user.UserRole.Equals("Admin"))
                {
                    // TODO
                }
                else if (user.UserRole.Equals("Customer"))
                {
                    // TODO
                }
            }
        }

        protected void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            int userId = user.UserID;
            String oldPassword = OldPasswordTB.Text;
            String newPassword = NewPasswordTB.Text;
            String currentPassword = user.UserPassword;

            ErrorLbl.Text = AuthController.validateChangePassword(oldPassword, newPassword, currentPassword);

            if (ErrorLbl.Text.Equals(""))
            {
                UserHandler.UpdatePassword(userId, newPassword);
                Response.Redirect("Profile.aspx");
            }
        }   
    }
}
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
    public partial class UpdateProfile : System.Web.UI.Page
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
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int userId = user.UserID;
            String newUsername = UsernameTB.Text;
            String newEmail = EmailTB.Text;
            String newGender = GenderList.SelectedValue.ToString();
            int genderIndex = GenderList.SelectedIndex;
            String newDOB = DateOfBirthTB.Text;

            ErrorLbl.Text = AuthController.validateUpdate(newUsername, newEmail, genderIndex, newDOB);

            if (ErrorLbl.Text.Equals(""))
            {
                AuthController.UpdateUser(userId, newUsername, newEmail, newGender, Convert.ToDateTime(newDOB));
                Response.Redirect("Profile.aspx");
            }
        }
    }
}
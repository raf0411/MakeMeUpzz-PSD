using Projek_Lab_PSD.Controllers;
using Projek_Lab_PSD.Handlers;
using Projek_Lab_PSD.Models;
using Projek_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projek_Lab_PSD.Views
{
    public partial class Register : System.Web.UI.Page
    {
        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            String username = UsernameTB.Text;
            String password = PasswordTB.Text;
            String confirmPassword = ConfirmPassTB.Text;
            String email = EmailTB.Text;
            String DOB = DateOfBirthTB.Text;
            String gender = GenderList.SelectedValue.ToString();
            int genderListIndex = GenderList.SelectedIndex;

            ErrorLbl.Text = AuthController.validateRegister(username, password, email, DOB, genderListIndex, confirmPassword);

            if (ErrorLbl.Text.Equals("Success"))
            {
                AuthController.Register(username, password, email, DOB, gender);
                Response.Redirect("~/Views/Login.aspx");
            }
        }
    }
}
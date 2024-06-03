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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            String username = UsernameTB.Text;
            String password = PasswordTB.Text;
            String confirmedPassword = ConfirmPassTB.Text;
            String email = EmailTB.Text;
            string dob = Request.Form["DOB"];
        
            if(username == "")
            {
                ErrorLbl.Text = "Username may not be empty!";
            }
            else if(username.Length <= 5 && username.Length >= 15)
            {
                ErrorLbl.Text = "Username must be between 5 and 15 characters!";
            }
            else if(email == "")
            {
                ErrorLbl.Text = "Email may not be empty!";
            }
            else if (!email.EndsWith(".com"))
            {
                ErrorLbl.Text = "Enter a valid email!";
            }
            else if (GenderList.SelectedIndex == -1)
            {
                ErrorLbl.Text = "Gender must be selected!";
            }
            else if(password == "")
            {
                ErrorLbl.Text = "Password may not be empty!";
            }
            else if (!IsAlphanumeric(password))
            {
                ErrorLbl.Text = "Password must be alphanumeric!";
            }
            else if(confirmedPassword != password)
            {
                ErrorLbl.Text = "Confirmed Password must match!";
            }
            else if (string.IsNullOrEmpty(dob))
            {
                ErrorLbl.Text = "Date of birth must be filled!";
            }
            else
            {
                ErrorLbl.Text = "User Registered Successfully!";
                ErrorLbl.ForeColor = System.Drawing.Color.Green;
                Response.Redirect("~/Views/Login.aspx");
            }
        }

        private bool IsAlphanumeric(String password)
        {
            // Regular expression to check if the password is alphanumeric
            String pattern = @"^[a-zA-Z0-9]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(password);
        }
    }
}
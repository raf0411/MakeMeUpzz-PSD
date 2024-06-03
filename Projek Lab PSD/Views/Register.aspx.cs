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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            String username = UsernameTB.Text;
            String password = PasswordTB.Text;
            String confirmedPassword = ConfirmPassTB.Text;
            String email = EmailTB.Text;
            DateTime DOB = Convert.ToDateTime(DateOfBirthTB.Text);
        
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
            else if (DOB.Equals(""))
            {
                ErrorLbl.Text = "Date of birth must be filled!";
            }
            else
            {
                ErrorLbl.Text = "User Registered Successfully!";
                ErrorLbl.ForeColor = System.Drawing.Color.Green;
                RegisterUser();
            }
        }
        public int GenerateUserID()
        {
            UserRepository userRepo = new UserRepository();

            int newID = 0;
            int lastID = userRepo.GetLastUserID();

            if (lastID == null)
            {
                lastID = 1;
            }
            else
            {
                lastID++;
            }

            newID = lastID;

            return newID;
        }

        private void RegisterUser()
        {
            UserRepository userRepo = new UserRepository();

            int newID = GenerateUserID();
            String newUsername = UsernameTB.Text.ToString();
            String newEmail = EmailTB.Text.ToString();
            DateTime newDOB = Convert.ToDateTime(DateOfBirthTB.Text);
            String newGender = GenderList.SelectedValue.ToString();
            String newRole = "Customer";
            String newPassword = ConfirmPassTB.Text.ToString();

            userRepo.InsertUser(newID, newUsername, newEmail, newDOB, newGender, newRole, newPassword);
            Response.Redirect("~/Views/Login.aspx");
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
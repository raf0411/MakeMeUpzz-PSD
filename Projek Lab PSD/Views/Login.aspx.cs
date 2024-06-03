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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            String username = UsernameTB.Text;
            String password = PasswordTB.Text;

            ErrorLbl.ForeColor = System.Drawing.Color.Red;

            if (username == "")
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
            else
            {
                ErrorLbl.Text = "User Login Successfully!";
                ErrorLbl.ForeColor = System.Drawing.Color.Green;

                Response.Redirect("~/Views/Home.aspx");
            }
        }
    }
}
using Projek_Lab_PSD.Controllers;
using Projek_Lab_PSD.Handlers;
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
    public partial class InsertMakeupType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                User user = (User)Session["user"]; ;

                if (!user.UserRole.Equals("Admin"))
                {
                    Response.Redirect("Home.aspx");
                }
            }
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            String MakeupTypeName = MakeupTypeNameTB.Text;

            ErrorLbl.Text = MakeupTypeController.validateMakeupType(MakeupTypeName);

            if (ErrorLbl.Text.Equals(""))
            {
                MakeupTypeController.InsertMakeupType(MakeupTypeName);
                Response.Redirect("~/Views/ManageMakeup.aspx");
            }  
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeup.aspx");
        }
    }
}
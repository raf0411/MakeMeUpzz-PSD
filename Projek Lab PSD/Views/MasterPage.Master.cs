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
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        private MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        protected void Page_Load(object sender, EventArgs e)
        {
            CustomerNav.Visible = false;
            AdminNav.Visible = false;

            User user = (User)Session["user"];

            if (user.UserRole.Equals("Customer"))
            {
                CustomerNav.Visible = true;
            }
            else if (user.UserRole.Equals("Admin"))
            {
                AdminNav.Visible = true;
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnManageMakeup_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageMakeup.aspx");
        }

        protected void btnOrderQueue_Click(object sender, EventArgs e)
        {
            // ???
        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void btnTransactionReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionReport.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            string[] cookies = Request.Cookies.AllKeys;

            foreach(string cookie in cookies)
            {
                Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
            }

            Application["user_count"] = ((int)Application["user_count"] - 1);
            Session.Remove("user");
            Response.Redirect("Login.aspx");
        }

        protected void btnOrderMakeup_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderMakeup.aspx");
        }

        protected void btnHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionHistory.aspx");
        }

        protected void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionHistory.aspx");
        }
    }
}
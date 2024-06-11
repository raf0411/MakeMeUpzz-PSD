using Projek_Lab_PSD.Controllers;
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
    public partial class TransactionHistory : System.Web.UI.Page
    {
        User user;
        List<TransactionHeader> customerTransactions = null;
        List<TransactionHeader> adminViewTransactions = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            CustomerGridView.Visible = false;
            AdminGridView.Visible = false;

            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                user = (User)Session["user"];
            }

            if (user.UserRole.Equals("Customer"))
            {
                CustomerGridView.Visible = true;
            }
            else if (user.UserRole.Equals("Admin"))
            {
                AdminGridView.Visible = true;
            }

            customerTransactions = TransactionController.GetTransactionHeadersByUserID(user.UserID);
            adminViewTransactions = TransactionController.GetTransactionHeaders();

            CustomerGridView.DataSource = customerTransactions;
            CustomerGridView.DataBind();

            AdminGridView.DataSource = adminViewTransactions;
            AdminGridView.DataBind();
        }

        protected void AdminGridView_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = AdminGridView.Rows[e.NewSelectedIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);

            Response.Redirect("~/Views/TransactionDetail.aspx?id=" + id);
        }

        protected void CustomerGridView_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = CustomerGridView.Rows[e.NewSelectedIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);

            Response.Redirect("~/Views/TransactionDetail.aspx?id=" + id);
        }
    }
}
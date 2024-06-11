using Projek_Lab_PSD.Controllers;
using Projek_Lab_PSD.Handlers;
using Projek_Lab_PSD.Models;
using Projek_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
//using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projek_Lab_PSD.Views
{
    public partial class HandleTransaction : System.Web.UI.Page
    {
        User user;
        List<TransactionHeader> transactionHeaders = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                user = (User)Session["user"];

                if (user == null || !user.UserRole.Equals("Admin"))
                {
                    Response.Redirect("Home.aspx");
                }
            }

            RefreshGridView();
        }

        protected void HandleTransactionGrid_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = HandleTransactionGrid.Rows[e.NewSelectedIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            TransactionController.UpdateStatusByID(id);
            RefreshGridView();
        }

        public void RefreshGridView()
        {
            transactionHeaders = TransactionController.GetTransactionHeaders();
            HandleTransactionGrid.DataSource = transactionHeaders;
            HandleTransactionGrid.DataBind();
        }
    }
}
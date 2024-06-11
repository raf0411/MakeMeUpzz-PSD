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
    public partial class TransactionDetail : System.Web.UI.Page
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
                user = (User)Session["user"];
            }

            int transactionId = Convert.ToInt32(Request.QueryString["id"]);

            TransactionDetailGrid.DataSource = TransactionController.GetTransactionDetailsByID(transactionId);
            TransactionDetailGrid.DataBind();
        }
    }
}
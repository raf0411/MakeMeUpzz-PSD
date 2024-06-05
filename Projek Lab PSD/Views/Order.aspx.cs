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
    public partial class Order : System.Web.UI.Page
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

                if (!user.UserRole.Equals("Customer"))
                {
                    Response.Redirect("Home.aspx");
                }
            }

            CartRepository cartRepo = new CartRepository();
        }

        protected void OrderBtn_Click(object sender, EventArgs e)
        {
            int userID = user.UserID;
            int makeupID = Convert.ToInt32(Request.QueryString["id"]);
            int quantity = Convert.ToInt32(QuantityTB.Text);

            ErrorLbl.Text = OrderController.validateOrder(quantity);

            if (ErrorLbl.Text.Equals(""))
            {
                OrderHandler.InsertCart(userID, makeupID, quantity);
                Response.Redirect("~/Views/OrderMakeup.aspx");
            }
        }
    }
}
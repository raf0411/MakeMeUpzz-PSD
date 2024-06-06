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
    public partial class OrderMakeup : System.Web.UI.Page
    {
        public List<Makeup> makeups = null;
        public List<Cart> carts = null;
        User user;

        protected void Page_Load(object sender, EventArgs e)
        {
            ClearCartBtn.Visible = false;
            CheckoutBtn.Visible = false;

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

            MakeupRepository makeupRepo = new MakeupRepository();
            CartRepository cartRepo = new CartRepository();

            makeups = makeupRepo.GetMakeups();
            carts = cartRepo.GetCartsByUserID(user.UserID);

            CartsGrid.DataSource = carts;
            MakeupsGrid.DataSource = makeups;
            MakeupsGrid.DataBind();
            CartsGrid.DataBind();

            if(carts.Count != 0)
            {
                ClearCartBtn.Visible = true;
                CheckoutBtn.Visible = true;
            }
        }

        protected void MakeupsGrid_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = MakeupsGrid.Rows[e.NewEditIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);

            Response.Redirect("~/Views/Order.aspx?id=" + id);
        }

        protected void ClearCartBtn_Click(object sender, EventArgs e)
        {
            OrderHandler.DeleteCartByUserID(user.UserID);
            RefreshCartGridView();
        }

        public void RefreshCartGridView()
        {
            CartRepository cartRepo = new CartRepository();

            carts = cartRepo.GetCartsByUserID(user.UserID);

            CartsGrid.DataSource = carts;
            CartsGrid.DataBind();
        }

        protected void CheckoutBtn_Click(object sender, EventArgs e)
        {
            int UserID = user.UserID;
            TransactionHandler.InsertTransaction(UserID);
            TransactionHandler.InsertTransactionDetail(UserID);

            CheckoutLbl.ForeColor = System.Drawing.Color.Green;
            CheckoutLbl.Text = "Checkout Successful!";
        }
    }
}
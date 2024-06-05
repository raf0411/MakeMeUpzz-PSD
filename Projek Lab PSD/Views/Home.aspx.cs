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
    public partial class Home : System.Web.UI.Page
    {
        public List<User> users = null;
        public List<Makeup> makeups = null;
        private MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();
        User user;

        protected void Page_Load(object sender, EventArgs e)
        {
            ListGridContainer.Visible = false;
            GridCustomerView.Visible = false;

            UserRepository userRepo = new UserRepository();
            MakeupRepository makeupRepo = new MakeupRepository();

            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                if (Session["user"] == null)
                {
                    int id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                    user = (from x in db.Users where x.UserID == id select x).FirstOrDefault();
                    Session["user"] = user;
                }
                else
                {
                    user = (User) Session["user"];
                }

                usernameLbl.Text = user.Username;
                roleLbl.Text = user.UserRole;

                if (Application["user_count"] != null)
                {
                    UserOnlineCount.Text = Application["user_count"] + " User(s) Online";
                }

                if (user.UserRole.Equals("Admin"))
                {
                    ListGridContainer.Visible = true;
                    GridCustomerView.Visible = false;

                    var q = (from x in db.Users select x);

                    foreach(var x in q)
                    {
                        UserList.Items.Add(x.Username);
                    }
                }
                else if (user.UserRole.Equals("Customer"))
                {
                    ListGridContainer.Visible = false;
                    GridCustomerView.Visible = true;
                }
            }

            users = userRepo.GetCustomers();
            makeups = makeupRepo.GetMakeups();

            MakeupsGrid.DataSource = makeups;
            UsersGrid.DataSource = users;
            MakeupsGrid.DataBind();
            UsersGrid.DataBind();
        }
    }
}
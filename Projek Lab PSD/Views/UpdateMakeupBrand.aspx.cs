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
    public partial class UpdateMakeupBrand : System.Web.UI.Page
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

            MakeupBrandRepository makeupBrandRepo = new MakeupBrandRepository();

            if (IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                MakeupBrand updateMakeupBrand = makeupBrandRepo.GetMakeupBrandByID(id);

                if (updateMakeupBrand != null)
                {
                    MakeupBrandNameTB.Text = updateMakeupBrand.MakeupBrandName;
                    MakeupBrandRatingTB.Text = updateMakeupBrand.MakeupBrandRating.ToString();
                }
                else
                {
                    Response.Redirect("~/Views/Home.aspx");
                }
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            MakeupBrandRepository makeupBrandRepo = new MakeupBrandRepository();
            int updateID = Convert.ToInt32(Request.QueryString["id"]);

            String makeupBrandName = MakeupBrandNameTB.Text;
            int makeupBrandRating = Convert.ToInt32(MakeupBrandRatingTB.Text);

            makeupBrandRepo.UpdateMakeupBrandByID(updateID, makeupBrandName, makeupBrandRating);

            Response.Redirect("~/Views/ManageMakeup.aspx");
        }
    }
}
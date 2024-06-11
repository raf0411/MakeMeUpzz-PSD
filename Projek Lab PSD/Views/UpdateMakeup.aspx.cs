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
    public partial class UpdateMakeup : System.Web.UI.Page
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

            if(IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Makeup updateMakeup = MakeupController.GetMakeupByID(id);

                if(updateMakeup != null)
                {
                    MakeupNameTB.Text = updateMakeup.MakeupName;
                    MakeupPriceTB.Text = updateMakeup.MakeupPrice.ToString();
                    MakeupWeightTB.Text = updateMakeup.MakeupWeight.ToString();
                    List<String> makeupTypeNames = MakeupTypeController.GetMakeupTypeNames();
                    List<String> makeupBrandNames = MakeupBrandController.GetMakeupBrandNames();

                    MakeupTypeDropdown.DataSource = makeupTypeNames;
                    MakeupBrandDropdown.DataSource = makeupBrandNames;

                    MakeupTypeDropdown.DataBind();
                    MakeupTypeDropdown.SelectedValue = MakeupTypeController.GetMakeupTypeNameByID(id);

                    MakeupBrandDropdown.DataBind();
                    MakeupBrandDropdown.SelectedValue = MakeupBrandController.GetMakeupBrandNameByID(id);

                }
                else
                {
                    Response.Redirect("~/Views/Home.aspx");
                }
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int updateID = Convert.ToInt32(Request.QueryString["id"]);
            String makeupName = MakeupNameTB.Text;
            int makeupPrice = Convert.ToInt32(MakeupPriceTB.Text);
            int makeupWeight = Convert.ToInt32(MakeupWeightTB.Text);
            String makeupTypeName = MakeupTypeDropdown.Text;
            String makeupBrandName = MakeupBrandDropdown.Text;

            ErrorLbl.Text = MakeupController.validateMakeup(makeupName, makeupPrice, makeupWeight);

            if(ErrorLbl.Text.Equals(""))
            {
                MakeupController.UpdateMakeup(updateID, makeupName, makeupPrice, makeupWeight, makeupTypeName, makeupBrandName);
                Response.Redirect("~/Views/ManageMakeup.aspx");
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeup.aspx");
        }
    }
}
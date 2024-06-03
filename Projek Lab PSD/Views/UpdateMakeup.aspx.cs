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

            MakeupRepository makeupRepo = new MakeupRepository();
            MakeupTypeRepository makeupTypeRepo = new MakeupTypeRepository();
            MakeupBrandRepository makeupBrandRepo = new MakeupBrandRepository(); 

            if(IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Makeup updateMakeup = makeupRepo.GetMakeupByID(id);

                if(updateMakeup != null)
                {
                    MakeupNameTB.Text = updateMakeup.MakeupName;
                    MakeupPriceTB.Text = updateMakeup.MakeupPrice.ToString();
                    MakeupWeightTB.Text = updateMakeup.MakeupWeight.ToString();
                    List<String> makeupTypeNames = makeupTypeRepo.GetMakeupTypeNames();
                    List<String> makeupBrandNames = makeupBrandRepo.GetMakeupBrandNames();

                    MakeupTypeDropdown.DataSource = makeupTypeNames;
                    MakeupBrandDropdown.DataSource = makeupBrandNames;

                    MakeupTypeDropdown.DataBind();
                    MakeupTypeDropdown.SelectedValue = makeupTypeRepo.GetMakeupTypeNameByID(id);

                    MakeupBrandDropdown.DataBind();
                    MakeupBrandDropdown.SelectedValue = makeupBrandRepo.GetMakeupBrandNameByID(id);

                }
                else
                {
                    Response.Redirect("~/Views/Home.aspx");
                }
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            MakeupRepository makeupRepo = new MakeupRepository();
            MakeupTypeRepository makeupTypeRepo = new MakeupTypeRepository();
            MakeupBrandRepository makeupBrandRepo = new MakeupBrandRepository();
            int updateID = Convert.ToInt32(Request.QueryString["id"]);

            String makeupName = MakeupNameTB.Text;
            int makeupPrice = Convert.ToInt32(MakeupPriceTB.Text);
            int makeupWeight = Convert.ToInt32(MakeupWeightTB.Text);
            String makeupTypeName = MakeupTypeDropdown.Text;
            String makeupBrandName = MakeupBrandDropdown.Text;
            int makeupTypeID = makeupTypeRepo.GetMakeupTypeIDByName(makeupTypeName);
            int makeupBrandID = makeupBrandRepo.GetMakeupBrandIDByName(makeupBrandName);

            makeupRepo.UpdateMakeupByID(updateID, makeupName, makeupPrice, makeupWeight, makeupTypeID, makeupBrandID);

            Response.Redirect("~/Views/ManageMakeup.aspx");
        }
    }
}
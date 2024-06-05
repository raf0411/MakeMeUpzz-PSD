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
    public partial class InsertMakeup : System.Web.UI.Page
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

            MakeupTypeRepository makeupTypeRepo = new MakeupTypeRepository();
            MakeupBrandRepository makeupBrandRepo = new MakeupBrandRepository();
            
            if(IsPostBack == false)
            {
                List<String> makeupTypeNames = makeupTypeRepo.GetMakeupTypeNames();
                List<String> makeupBrandNames = makeupBrandRepo.GetMakeupBrandNames();
                
                MakeupTypeDropdown.DataSource = makeupTypeNames;
                MakeupBrandDropdown.DataSource = makeupBrandNames;

                MakeupTypeDropdown.DataBind();
                MakeupBrandDropdown.DataBind();
            }
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            String MakeupName = MakeupNameTB.Text;
            int MakeupPrice = Convert.ToInt32(MakeupPriceTB.Text);
            int MakeupWeight = Convert.ToInt32(MakeupWeightTB.Text);
            String MakeupTypeName = MakeupTypeDropdown.Text;
            String MakeupBrandName = MakeupBrandDropdown.Text;
            int typeSelectedIndex = MakeupTypeDropdown.SelectedIndex;
            int brandSelectedIndex = MakeupBrandDropdown.SelectedIndex;

            ErrorLbl.Text = MakeupController.validateMakeup(MakeupName, MakeupPrice, MakeupWeight);

            if (ErrorLbl.Text.Equals(""))
            {
                MakeupHandler.InsertMakeup(MakeupName,  MakeupPrice, MakeupWeight, MakeupTypeName, MakeupBrandName);
                Response.Redirect("~/Views/ManageMakeup.aspx");
            }
        }
    }
}
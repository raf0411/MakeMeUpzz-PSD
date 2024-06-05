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
    public partial class UpdateMakeupType : System.Web.UI.Page
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

            if (IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                MakeupType updateMakeupType = makeupTypeRepo.GetMakeupTypeByID(id);

                if (updateMakeupType != null)
                {
                    MakeupTypeNameTB.Text = updateMakeupType.MakeupTypeName;
                }
                else
                {
                    Response.Redirect("~/Views/Home.aspx");
                }
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            MakeupTypeRepository makeupTypeRepo = new MakeupTypeRepository();
            int updateID = Convert.ToInt32(Request.QueryString["id"]);

            String makeupTypeName = MakeupTypeNameTB.Text;

            ErrorLbl.Text = MakeupTypeController.validateMakeupType(makeupTypeName);

            if (ErrorLbl.Text.Equals(""))
            {
                MakeupTypeHandler.UpdateMakeupType(updateID, makeupTypeName);
                Response.Redirect("~/Views/ManageMakeup.aspx");
            }         
        }
    }
}
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
    public partial class ManageMakeup : System.Web.UI.Page
    {
        public List<Makeup> makeups = null;
        public List<MakeupType> makeupTypes = null;
        public List<MakeupBrand> makeupBrands = null;

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

            makeups = makeupRepo.GetMakeups();
            makeupTypes = makeupTypeRepo.GetMakeupTypes();
            makeupBrands = makeupBrandRepo.GetMakeupBrands();

            MakeupGrid.DataSource = makeups;
            MakeupGrid.DataBind();
            MakeupTypeGrid.DataSource = makeupTypes;
            MakeupTypeGrid.DataBind();
            MakeupBrandGrid.DataSource = makeupBrands;
            MakeupBrandGrid.DataBind();
        }

        protected void InsertPageBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertMakeup.aspx");
        }

        protected void InsertMakeupTypeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertMakeupType.aspx");

        }

        protected void InsertMakeupBrandBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertMakeupBrand.aspx");

        }

        protected void MakeupGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            MakeupRepository makeupRepo = new MakeupRepository();
            GridViewRow row = MakeupGrid.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            makeupRepo.DeleteMakeupByID(id);

            makeups = makeupRepo.GetMakeups();
            MakeupGrid.DataSource = makeups;
            MakeupGrid.DataBind();
        }

        protected void MakeupGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = MakeupGrid.Rows[e.NewEditIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);

            Response.Redirect("~/Views/UpdateMakeup.aspx?id=" + id);
        }

        protected void MakeupTypeGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            MakeupTypeRepository makeupTypeRepo = new MakeupTypeRepository();
            GridViewRow row = MakeupTypeGrid.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            makeupTypeRepo.DeleteMakeupTypeByID(id);

            makeupTypes = makeupTypeRepo.GetMakeupTypes();
            MakeupTypeGrid.DataSource = makeupTypes;
            MakeupTypeGrid.DataBind();
        }

        protected void MakeupTypeGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = MakeupTypeGrid.Rows[e.NewEditIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);

            Response.Redirect("~/Views/UpdateMakeupType.aspx?id=" + id);
        }

        protected void MakeupBrandGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            MakeupBrandRepository makeupBrandRepo = new MakeupBrandRepository();
            GridViewRow row = MakeupBrandGrid.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            makeupBrandRepo.DeleteMakeupBrandByID(id);

            makeupBrands= makeupBrandRepo.GetMakeupBrands();
            MakeupBrandGrid.DataSource = makeupBrands;
            MakeupBrandGrid.DataBind();
        }

        protected void MakeupBrandGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = MakeupBrandGrid.Rows[e.NewEditIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);

            Response.Redirect("~/Views/UpdateMakeupBrand.aspx?id=" + id);
        }
    }
}
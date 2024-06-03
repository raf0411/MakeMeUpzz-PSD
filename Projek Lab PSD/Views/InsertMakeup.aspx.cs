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

        public int GenerateMakeupID()
        {
            MakeupRepository makeupRepo = new MakeupRepository();

            int newID = 0;
            int lastID = makeupRepo.GetLastMakeupID();

            if(lastID == null)
            {
                lastID = 1;
            }
            else
            {
                lastID++;
            }

            newID = lastID;

            return newID;
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            MakeupRepository makeupRepo = new MakeupRepository();
            MakeupTypeRepository makeupTypeRepo = new MakeupTypeRepository();
            MakeupBrandRepository makeupBrandRepo = new MakeupBrandRepository();

            int MakeupID = GenerateMakeupID();
            String MakeupName = MakeupNameTB.Text;
            int MakeupPrice = Convert.ToInt32(MakeupPriceTB.Text);
            int MakeupWeight = Convert.ToInt32(MakeupWeightTB.Text);
            String MakeupTypeName = MakeupTypeDropdown.Text;
            String MakeupBrandName = MakeupBrandDropdown.Text;
            int MakeupTypeID = makeupTypeRepo.GetMakeupTypeIDByName(MakeupTypeName);
            int MakeupBrandID = makeupBrandRepo.GetMakeupBrandIDByName(MakeupBrandName);

            makeupRepo.InsertMakeup(MakeupID, MakeupName, MakeupPrice, MakeupWeight, MakeupTypeID, MakeupBrandID);

            Response.Redirect("~/Views/ManageMakeup.aspx");
        }
    }
}
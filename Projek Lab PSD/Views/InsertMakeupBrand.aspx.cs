using Projek_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projek_Lab_PSD.Views
{
    public partial class InsertMakeupBrand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public int GenerateMakeupBrandID()
        {
            MakeupBrandRepository makeupBrandRepo = new MakeupBrandRepository();

            int newID = 0;
            int lastID = makeupBrandRepo.GetLastMakeupBrandID();

            if (lastID == null)
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
            MakeupBrandRepository makeupBrandRepo = new MakeupBrandRepository();

            int MakeupBrandID = GenerateMakeupBrandID();
            String MakeupBrandName = MakeupBrandNameTB.Text;
            int MakeupBrandRating = Convert.ToInt32(MakeupBrandRatingTB.Text);

            makeupBrandRepo.InsertMakeupBrand(MakeupBrandID, MakeupBrandName, MakeupBrandRating);

            Response.Redirect("~/Views/ManageMakeup.aspx");
        }
    }
}
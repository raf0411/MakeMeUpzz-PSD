using Projek_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projek_Lab_PSD.Views
{
    public partial class InsertMakeupType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public int GenerateMakeupTypeID()
        {
            MakeupTypeRepository makeupTypeRepo = new MakeupTypeRepository();

            int newID = 0;
            int lastID = makeupTypeRepo.GetLastMakeupTypeID();

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
            MakeupTypeRepository makeupTypeRepo = new MakeupTypeRepository();

            int MakeupTypeID = GenerateMakeupTypeID();
            String MakeupTypeName = MakeupTypeNameTB.Text;

            makeupTypeRepo.InsertMakeupType(MakeupTypeID, MakeupTypeName);

            Response.Redirect("~/Views/ManageMakeup.aspx");
        }
    }
}
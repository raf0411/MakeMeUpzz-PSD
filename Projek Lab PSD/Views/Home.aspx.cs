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
        public List<Makeup> makeups = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            MakeupRepository makeupRepo = new MakeupRepository();

            makeups = makeupRepo.GetMakeups();
            MakeUpGrid.DataSource = makeups;
            MakeUpGrid.DataBind();
        }
    }
}
using Projek_Lab_PSD.Controllers;
using Projek_Lab_PSD.Datasets;
using Projek_Lab_PSD.Handlers;
using Projek_Lab_PSD.Models;
using Projek_Lab_PSD.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projek_Lab_PSD.Views
{
    public partial class TransactionReport : System.Web.UI.Page
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

                if (user == null || !user.UserRole.Equals("Admin"))
                {
                    Response.Redirect("Home.aspx");
                }
            }

            MakeMeUpzzReport report = new MakeMeUpzzReport();
            TransactionReportViewer.ReportSource = report;

            Dataset data = GetDataset(TransactionController.GetTransactions());
            report.SetDataSource(data);
        }

        private Dataset GetDataset(List<TransactionHeader> transactions)
        {
            Dataset dataset = new Dataset();
            var TableHeader = dataset.TransactionHeader;
            var TableDetail = dataset.TransactionDetails;

            foreach (var t in transactions)
            {
                var hrow = TableHeader.NewRow();
                hrow["TransactionID"] = t.TransactionID;
                hrow["UserID"] = t.UserID;
                hrow["TransactionDate"] = t.TransactionDate;
                hrow["Status"] = t.Status;
                TableHeader.Rows.Add(hrow);

                foreach (var d in t.TransactionDetails)
                {
                    var drow = TableDetail.NewRow();
                    drow["TransactionID"] = d.TransactionID;
                    drow["MakeupID"] = d.MakeupID;
                    drow["Quantity"] = d.Quantity;
                    drow["Price"] = d.Quantity * d.Makeup.MakeupPrice;
                    TableDetail.Rows.Add(drow);
                }
            }

            return dataset;
        }
    }
}
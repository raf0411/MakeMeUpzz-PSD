<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="TransactionReport.aspx.cs" Inherits="Projek_Lab_PSD.Views.TransactionReport" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <div class="transaction-report-container">
        <h1>Transaction Report</h1>

        <div>
            <CR:CrystalReportViewer ID="TransactionReportViewer" runat="server" AutoDataBind="true" />
        </div>
    </div>
</asp:Content>

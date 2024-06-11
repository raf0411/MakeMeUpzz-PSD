<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="TransactionDetail.aspx.cs" Inherits="Projek_Lab_PSD.Views.TransactionDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">

    <div class="transaction-detail-container">
        <h1>Transaction Detail</h1>

        <h1>Transaction ID: <%=Request.QueryString["id"] %></h1>

        <div class="transaction-detail-grid-view">
            <asp:GridView ID="TransactionDetailGrid" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="TransactionHeader.User.Username" HeaderText="User" SortExpression="TransactionHeader.User.Username" />
                    <asp:BoundField DataField="Makeup.MakeupName" HeaderText="Makeup Name" SortExpression="Makeup.MakeupName" />
                    <asp:BoundField DataField="Makeup.MakeupPrice" HeaderText="Price" SortExpression="Makeup.MakeupPrice" />
                    <asp:BoundField DataField="Makeup.MakeupWeight" HeaderText="Weight (grams)" SortExpression="Makeup.MakeupWeight" />
                    <asp:BoundField DataField="Makeup.MakeupType.MakeupTypeName" HeaderText="Type" SortExpression="Makeup.MakeupType.MakeupTypeName" />
                    <asp:BoundField DataField="Makeup.MakeupBrand.MakeupBrandName" HeaderText="Brand" SortExpression="Makeup.MakeupBrand.MakeupBrandName" />
                    <asp:BoundField DataField="Makeup.MakeupBrand.MakeupBrandRating" HeaderText="Rating" SortExpression="Makeup.MakeupBrand.MakeupBrandRating" />
                    <asp:BoundField DataField="TransactionHeader.TransactionDate" HeaderText="Transaction Date" SortExpression="TransactionHeader.TransactionDate" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>

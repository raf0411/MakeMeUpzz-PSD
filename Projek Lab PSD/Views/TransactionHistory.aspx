<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="Projek_Lab_PSD.Views.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <h1>Transaction History</h1>

    <div class="customer-transaction-view">
        <asp:GridView ID="CustomerGridView" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanging="CustomerGridView_SelectedIndexChanging">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID" />
                <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                <asp:CommandField ButtonType="Button" HeaderText="Detail" SelectText="Detail" ShowHeader="True" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>

    <div class="admin-transaction-view">
        <asp:GridView ID="AdminGridView" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanging="AdminGridView_SelectedIndexChanging">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID" />
                <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID" />
                <asp:BoundField DataField="User.UserName" HeaderText="User" SortExpression="User.Username" />
                <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                <asp:CommandField ButtonType="Button" HeaderText="Detail" SelectText="Detail" ShowHeader="True" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

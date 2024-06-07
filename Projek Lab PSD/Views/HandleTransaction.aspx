<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="HandleTransaction.aspx.cs" Inherits="Projek_Lab_PSD.Views.HandleTransaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <h1>Handle Transaction</h1>

    <div class="handle-transaction-grid">
        <asp:GridView ID="HandleTransactionGrid" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanging="HandleTransactionGrid_SelectedIndexChanging">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
                <asp:BoundField DataField="User.Username" HeaderText="User" SortExpression="User.Username" />
                <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" SortExpression="TransactionDate" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                <asp:CommandField ButtonType="Button" EditText="Handle" HeaderText="Handle" SelectText="Handle" ShowHeader="True" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

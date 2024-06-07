<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="OrderMakeup.aspx.cs" Inherits="Projek_Lab_PSD.Views.OrderMakeup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">

    <div class="order-makeup-container">

        <div class="makeup-detail-grid">
            <h2>Makeup Details</h2>

            <asp:GridView ID="MakeupsGrid" runat="server" AutoGenerateColumns="False" OnRowEditing="MakeupsGrid_RowEditing1" >
                <Columns>
                    <asp:BoundField DataField="MakeupID" HeaderText="ID" SortExpression="MakeupID" />
                    <asp:BoundField DataField="MakeupName" HeaderText="Name" SortExpression="MakeupName" />
                    <asp:BoundField DataField="MakeupPrice" HeaderText="Price" SortExpression="MakeupPrice" />
                    <asp:BoundField DataField="MakeupWeight" HeaderText="Weight (grams)" SortExpression="MakeupWeight" />
                    <asp:BoundField DataField="MakeupType.MakeupTypeName" HeaderText="Type" SortExpression="MakeupType.MakeupTypeName" />
                    <asp:BoundField DataField="MakeupBrand.MakeupBrandName" HeaderText="Brand" SortExpression="MakeupBrand.MakeupBrandName" />
                    <asp:CommandField ButtonType="Button" EditText="Order" HeaderText="Order" ShowCancelButton="False" ShowEditButton="True" ShowHeader="True" />
                </Columns>
            </asp:GridView>
        </div>

        <div class="carts-grid">
            <h2>Your Cart</h2>

            <asp:GridView ID="CartsGrid" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="CartID" HeaderText="CartID" SortExpression="CartID" />
                    <asp:BoundField DataField="Makeup.MakeupName" HeaderText="Makeup" SortExpression="Makeup.MakeupName" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                </Columns>
            </asp:GridView>
        </div>

        <asp:Button ID="ClearCartBtn" runat="server" Text="Clear Cart" OnClick="ClearCartBtn_Click" />

        <asp:Button ID="CheckoutBtn" runat="server" Text="Checkout" OnClick="CheckoutBtn_Click" />

        <asp:Label ID="CheckoutLbl" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>

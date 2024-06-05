<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Projek_Lab_PSD.Views.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <h1>Order</h1>

     <h1><%=Request.QueryString["id"] %></h1>

    <div>
        <asp:Label ID="QuantityLbl" runat="server" Text="Quantity"></asp:Label>
        <asp:TextBox TextMode="Number" ID="QuantityTB" runat="server"></asp:TextBox>
    </div>

    <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>

    <asp:Button ID="OrderBtn" runat="server" Text="Order" OnClick="OrderBtn_Click" />

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Projek_Lab_PSD.Views.Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">

    <div class="order-container">
        <h1>Order</h1>

        <h1>Makeup ID: <%=Request.QueryString["id"] %></h1>

        <div class="input-box">
            <asp:Label ID="QuantityLbl" runat="server" Text="Quantity"></asp:Label>
            <asp:TextBox TextMode="Number" ID="QuantityTB" runat="server" Text="0" CssClass="input"></asp:TextBox>
        </div>

        <asp:Label CssClass="error-lbl" ID="ErrorLbl" runat="server" Text=""></asp:Label>

        <asp:Button ID="OrderBtn" runat="server" Text="Order" OnClick="OrderBtn_Click" CssClass="submit-btn"/>
    </div>
</asp:Content>

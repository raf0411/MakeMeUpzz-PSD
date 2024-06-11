<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateMakeup.aspx.cs" Inherits="Projek_Lab_PSD.Views.UpdateMakeup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">

    <div class="update-makeup-container">
        <h1>Update Makeup</h1>

        <h1><%=Request.QueryString["id"] %></h1>

        <div class="input-box">
            <asp:Label ID="MakeupNameLbl" runat="server" Text="Makeup Name"></asp:Label>
            <asp:TextBox ID="MakeupNameTB" runat="server" CssClass="input"></asp:TextBox>
        </div>

        <div class="input-box">
            <asp:Label ID="MakeupPriceLbl" runat="server" Text="Makeup Price"></asp:Label>
            <asp:TextBox TextMode="Number" ID="MakeupPriceTB" runat="server" Text="0" CssClass="input"></asp:TextBox>
        </div>

        <div class="input-box">
            <asp:Label ID="MakeupWeightLbl" runat="server" Text="Makeup Weight"></asp:Label>
            <asp:TextBox TextMode="Number" ID="MakeupWeightTB" runat="server" Text="0" CssClass="input"></asp:TextBox>
        </div>

        <div class="input-box">
            <asp:Label ID="MakeupTypeLbl" runat="server" Text="Makeup Type"></asp:Label>
            <asp:DropDownList ID="MakeupTypeDropdown" runat="server" CssClass="input"></asp:DropDownList>
        </div>

        <div class="input-box">
            <asp:Label ID="MakeupBrandLbl" runat="server" Text="Makeup Brand"></asp:Label>
            <asp:DropDownList ID="MakeupBrandDropdown" runat="server" CssClass="input"></asp:DropDownList>
        </div>

        <div>
            <asp:Label CssClass="error-lbl" ID="ErrorLbl" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Button CssClass="update-btn" ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" />
        </div>

        <div>
            <asp:Button CssClass="update-btn" ID="BackBtn" runat="server" Text="Back to Manage Makeup" OnClick="BackBtn_Click" />
        </div>
    </div>
</asp:Content>

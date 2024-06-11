<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateMakeupBrand.aspx.cs" Inherits="Projek_Lab_PSD.Views.UpdateMakeupBrand" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <div class="update-makeup-brand-container">
        <h1>Update Makeup Brand</h1>

        <h2>Makeup Brand ID: <%=Request.QueryString["id"] %></h2>

        <div class="form">
            <div class="input-box">
                <asp:Label ID="MakeupBrandNameLbl" runat="server" Text="Makeup Brand Name"></asp:Label>
                <asp:TextBox ID="MakeupBrandNameTB" runat="server" CssClass="input"></asp:TextBox>
            </div>

            <div class="input-box">
                <asp:Label ID="MakeupBrandRatingLbl" runat="server" Text="Rating"></asp:Label>
                <asp:TextBox TextMode="Number" ID="MakeupBrandRatingTB" runat="server" Text="0" CssClass="input"></asp:TextBox>
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
    </div>

</asp:Content>

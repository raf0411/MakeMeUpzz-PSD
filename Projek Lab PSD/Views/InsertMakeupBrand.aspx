<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="InsertMakeupBrand.aspx.cs" Inherits="Projek_Lab_PSD.Views.InsertMakeupBrand" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">

    <div class="container">
        <h1>Insert Makeup Brand</h1>

        <div class="form">
            <div class="input-box">
                <asp:Label ID="MakeupBrandNameLbl" runat="server" Text="Makeup Brand Name"></asp:Label>
                <asp:TextBox ID="MakeupBrandNameTB" runat="server" CssClass="input"></asp:TextBox>
            </div>

            <div class="input-box">
                <asp:Label ID="MakeupBrandRatingLbl" runat="server" Text="Rating"></asp:Label>
                <asp:TextBox TextMode="Number" ID="MakeupBrandRatingTB" runat="server" CssClass="input" Text="0"></asp:TextBox>
            </div>

            <div>
                <asp:Label CssClass="error-lbl" ID="ErrorLbl" runat="server" Text=""></asp:Label>
            </div>

            <div>
                <asp:Button CssClass="insert-btn" ID="InsertBtn" runat="server" Text="Insert" OnClick="InsertBtn_Click" />
            </div>

            <div>
                <asp:Button CssClass="update-btn" ID="BackBtn" runat="server" Text="Back to Manage Makeup" OnClick="BackBtn_Click" />
            </div>
        </div>
    </div>
</asp:Content>

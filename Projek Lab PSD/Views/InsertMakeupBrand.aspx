<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="InsertMakeupBrand.aspx.cs" Inherits="Projek_Lab_PSD.Views.InsertMakeupBrand" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <h1>Insert Makeup Brand</h1>

    <hr />

    <div>
        <asp:Label ID="MakeupBrandNameLbl" runat="server" Text="Makeup Brand Name"></asp:Label>
        <asp:TextBox ID="MakeupBrandNameTB" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="MakeupBrandRatingLbl" runat="server" Text="Rating"></asp:Label>
        <asp:TextBox ID="MakeupBrandRatingTB" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Button ID="InsertBtn" runat="server" Text="Insert" OnClick="InsertBtn_Click"/>
    </div>
</asp:Content>

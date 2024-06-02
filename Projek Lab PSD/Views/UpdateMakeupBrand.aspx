<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateMakeupBrand.aspx.cs" Inherits="Projek_Lab_PSD.Views.UpdateMakeupBrand" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <h1>Update Makeup Brand</h1>
    
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
        <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click"/>
    </div>
</asp:Content>

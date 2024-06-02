<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateMakeupType.aspx.cs" Inherits="Projek_Lab_PSD.Views.UpdateMakeupType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <h1>Update Makeup Type</h1>

    <h1><%=Request.QueryString["id"] %></h1>

    <hr />

    <div>
        <asp:Label ID="MakeupTypeNameLbl" runat="server" Text="Makeup Type Name"></asp:Label>
        <asp:TextBox ID="MakeupTypeNameTB" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" />
    </div>
</asp:Content>

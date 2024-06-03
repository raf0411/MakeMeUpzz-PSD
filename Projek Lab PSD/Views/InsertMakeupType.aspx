<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="InsertMakeupType.aspx.cs" Inherits="Projek_Lab_PSD.Views.InsertMakeupType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <h1>Insert Makeup Type</h1>

    <hr />

    <div>
        <asp:Label ID="MakeupTypeName" runat="server" Text="Makeup Type Name"></asp:Label>
        <asp:TextBox ID="MakeupTypeNameTB" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Button ID="InsertBtn" runat="server" Text="Insert" OnClick="InsertBtn_Click" />
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="Projek_Lab_PSD.Views.ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">

    <div class="container">

        <h2>Change Password</h2>

        <div class="form">
            <asp:Label ID="OldPasswordLbl" runat="server" Text="Old Password"></asp:Label>
            <asp:TextBox ID="OldPasswordTB" runat="server" placeholder="Old Password"></asp:TextBox>
        </div>

        <div class="form">
            <asp:Label ID="NewPasswordLbl" runat="server" Text="New Password"></asp:Label>
            <asp:TextBox ID="NewPasswordTB" runat="server" placeholder="New Password"></asp:TextBox>
        </div>

        <asp:Label CssClass="error-lbl" ID="ErrorLbl" runat="server" Text=""></asp:Label>

        <asp:Button CssClass="update-btn" ID="ChangePasswordBtn" runat="server" Text="Change Password" OnClick="ChangePasswordBtn_Click" />
    </div>

</asp:Content>

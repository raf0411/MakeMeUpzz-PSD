<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="Projek_Lab_PSD.Views.UpdateProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">

    <div class="update-profile-container">
        <h2>Update Profile</h2>

        <div class="form">
            <div class="tb-container">
                <asp:Label CssClass="input-lbl" ID="UsernameLbl" runat="server" Text="Username"></asp:Label>
                <asp:TextBox CssClass="input" ID="UsernameTB" runat="server" placeholder="Your New Username"></asp:TextBox>
            </div>

            <div class="tb-container">
                <asp:Label CssClass="input-lbl" ID="EmailLbl" runat="server" Text="Email"></asp:Label>
                <asp:TextBox TextMode="Email" CssClass="input" ID="EmailTB" runat="server" placeholder="Your New Email"></asp:TextBox>
            </div>

            <div class="tb-container">
                <asp:Label ID="GenderLbl" runat="server" Text="Gender" CssClass="lbl"></asp:Label>
                <asp:RadioButtonList ID="GenderList" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </div>

            <div class="tb-container">
                <asp:Label CssClass="input-lbl" ID="DateOfBirthLBL" runat="server" Text="Date of Birth"></asp:Label>
                <asp:TextBox TextMode="Date" CssClass="input" ID="DateOfBirthTB" runat="server"></asp:TextBox>
            </div>
        </div>

        <asp:Label CssClass="error-lbl" ID="ErrorLbl" runat="server" Text=""></asp:Label>
        <asp:Button CssClass="update-btn" ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" />

    </div>
</asp:Content>

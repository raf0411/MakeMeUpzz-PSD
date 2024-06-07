<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Projek_Lab_PSD.Views.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">

    <div class="user-container">
        <h1>User Profile</h1>

        <div class="user-info-container">
            <div class="user-info-box">
                <asp:Label CssClass="label" ID="UsernameLbl" runat="server" Text="Username"></asp:Label>
                <div class="background">
                    <asp:Label CssClass="info-text" ID="Username" runat="server" Text=""></asp:Label>
                </div>
            </div>

            <div class="user-info-box">
                <asp:Label CssClass="label" ID="EmailLbl" runat="server" Text="Email"></asp:Label>

                <div class="background">
                    <asp:Label CssClass="info-text" ID="Email" runat="server" Text=""></asp:Label>
                </div>
            </div>

            <div class="user-info-box">
                <asp:Label CssClass="label" ID="GenderLbl" runat="server" Text="Gender"></asp:Label>

                <div class="background">
                    <asp:Label CssClass="info-text" ID="Gender" runat="server" Text=""></asp:Label>
                </div>
            </div>

            <div class="user-info-box">
                <asp:Label CssClass="label" ID="DOBLbl" runat="server" Text="Date of Birth"></asp:Label>

                <div class="background">
                    <asp:Label CssClass="info-text" ID="DOB" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>

        <div class="profile-btn-container">
            <asp:Button CssClass="update-btn" ID="UpdateProfileBtn" runat="server" Text="Update Profile" OnClick="UpdateProfileBtn_Click" />
            <asp:Button CssClass="change-password-btn" ID="ChangePasswordBtn" runat="server" Text="Change Password" OnClick="ChangePasswordBtn_Click" />
        </div>

    </div>
</asp:Content>

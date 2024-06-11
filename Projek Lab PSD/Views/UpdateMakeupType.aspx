<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateMakeupType.aspx.cs" Inherits="Projek_Lab_PSD.Views.UpdateMakeupType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <div class="update-makeup-type-container">
        <h1>Update Makeup Type</h1>

        <h2>Makeup Type ID: <%=Request.QueryString["id"] %></h2>

        <div class="form">
            <div class="input-box">
                <asp:Label ID="MakeupTypeNameLbl" runat="server" Text="Makeup Type Name"></asp:Label>
                <asp:TextBox ID="MakeupTypeNameTB" runat="server" CssClass="input"></asp:TextBox>
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

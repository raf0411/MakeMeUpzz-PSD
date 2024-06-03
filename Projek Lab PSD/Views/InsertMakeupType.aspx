<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="InsertMakeupType.aspx.cs" Inherits="Projek_Lab_PSD.Views.InsertMakeupType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">

    <div class="container">
        <h1>Insert Makeup Type</h1>

        <div class="form">
            <div class="input-box">
                <asp:Label ID="MakeupTypeName" runat="server" Text="Makeup Type Name"></asp:Label>
                <asp:TextBox ID="MakeupTypeNameTB" runat="server" CssClass="input"></asp:TextBox>
            </div>

            <div>
                <asp:Label CssClass="error-lbl" ID="ErrorLbl" runat="server" Text=""></asp:Label>
            </div>

            <div>
                <asp:Button CssClass="insert-btn" ID="InsertBtn" runat="server" Text="Insert" OnClick="InsertBtn_Click" />
            </div>
        </div>
    </div>
</asp:Content>

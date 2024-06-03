<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="InsertMakeup.aspx.cs" Inherits="Projek_Lab_PSD.Views.InsertMakeup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <div class="container">
        <h1>Insert Makeup</h1>

        <div class="form">
            <div class="input-box">
                <asp:Label ID="MakeupNameLbl" runat="server" Text="Makeup Name"></asp:Label>
                <asp:TextBox ID="MakeupNameTB" runat="server" CssClass="input"></asp:TextBox>
            </div>

            <div class="input-box">
                <asp:Label ID="MakeupPriceLbl" runat="server" Text="Makeup Price"></asp:Label>
                <asp:TextBox TextMode="Number" ID="MakeupPriceTB" runat="server" CssClass="input"></asp:TextBox>
            </div>

            <div class="input-box">
                <asp:Label ID="MakeupWeightLbl" runat="server" Text="Makeup Weight"></asp:Label>
                <asp:TextBox TextMode="Number" ID="MakeupWeightTB" runat="server" CssClass="input"></asp:TextBox>
            </div>

            <div class="input-box">
                <asp:Label ID="MakeupTypeLbl" runat="server" Text="Makeup Type"></asp:Label>
                <asp:DropDownList ID="MakeupTypeDropdown" runat="server" CssClass="input"></asp:DropDownList>
            </div>

            <div class="input-box">
                <asp:Label ID="MakeupBrandLbl" runat="server" Text="Makeup Brand"></asp:Label>
                <asp:DropDownList ID="MakeupBrandDropdown" runat="server" CssClass="input"></asp:DropDownList>
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

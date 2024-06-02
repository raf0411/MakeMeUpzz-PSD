<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateMakeup.aspx.cs" Inherits="Projek_Lab_PSD.Views.UpdateMakeup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <h1>Update Makeup</h1>

    <h1><%=Request.QueryString["id"] %></h1>

    <hr />

    <div>
        <asp:Label ID="MakeupNameLbl" runat="server" Text="Makeup Name"></asp:Label>
        <asp:TextBox ID="MakeupNameTB" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="MakeupPriceLbl" runat="server" Text="Makeup Price"></asp:Label>
        <asp:TextBox ID="MakeupPriceTB" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="MakeupWeightLbl" runat="server" Text="Makeup Weight"></asp:Label>
        <asp:TextBox ID="MakeupWeightTB" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="MakeupTypeLbl" runat="server" Text="Makeup Type"></asp:Label>
        <asp:DropDownList ID="MakeupTypeDropdown" runat="server"></asp:DropDownList>
    </div>

    <div>
        <asp:Label ID="MakeupBrandLbl" runat="server" Text="Makeup Brand"></asp:Label>
        <asp:DropDownList ID="MakeupBrandDropdown" runat="server"></asp:DropDownList>
    </div>

    <div>
        <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" />
    </div>

</asp:Content>

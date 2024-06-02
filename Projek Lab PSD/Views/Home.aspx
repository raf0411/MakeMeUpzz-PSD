<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Projek_Lab_PSD.Views.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <h1>Home</h1>
    <hr />

    <div>
        <asp:GridView ID="MakeUpGrid" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="MakeupID" HeaderText="MakeupID" SortExpression="MakeupID" />
                <asp:BoundField DataField="MakeupName" HeaderText="MakeupName" SortExpression="MakeupName" />
                <asp:BoundField DataField="MakeupPrice" HeaderText="MakeupPrice" SortExpression="MakeupPrice" />
                <asp:BoundField DataField="MakeupWeight" HeaderText="MakeupWeight" SortExpression="MakeupWeight" />
                <asp:BoundField DataField="MakeupType.MakeupTypeName" HeaderText="MakeupType" SortExpression="MakeupType.MakeupTypeName" />
                <asp:BoundField DataField="MakeupBrand.MakeupBrandName" HeaderText="MakeupBrand" SortExpression="MakeupBrand.MakeupBrandName" />
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>

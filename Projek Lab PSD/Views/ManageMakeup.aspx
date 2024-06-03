<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="ManageMakeup.aspx.cs" Inherits="Projek_Lab_PSD.Views.ManageMakeup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <div class="manage-makeup">
        <h1>Manage Makeup</h1>
        <hr />

        <div class="grid-container">
            <div class="grid-view">
                <h2>Makeup Table</h2>

                <asp:GridView CssClass="grid" ID="MakeupGrid" runat="server" AutoGenerateColumns="false" OnRowDeleting="MakeupGrid_RowDeleting" OnRowEditing="MakeupGrid_RowEditing">
                    <Columns>
                        <asp:BoundField DataField="MakeupID" HeaderText="ID" SortExpression="MakeupID" />
                        <asp:BoundField DataField="MakeupName" HeaderText="MakeupName" SortExpression="MakeupName" />
                        <asp:BoundField DataField="MakeupPrice" HeaderText="MakeupPrice" SortExpression="MakeupPrice" />
                        <asp:BoundField DataField="MakeupWeight" HeaderText="MakeupWeight" SortExpression="MakeupWeight" />
                        <asp:BoundField DataField="MakeupType.MakeupTypeName" HeaderText="MakeupType" SortExpression="MakeupType.MakeupTypeName" />
                        <asp:BoundField DataField="MakeupBrand.MakeupBrandName" HeaderText="MakeupBrand" SortExpression="MakeupBrand.MakeupBrandName" />
                        <asp:BoundField DataField="MakeupBrand.MakeupBrandRating" HeaderText="Rating" SortExpression="MakeupBrand.MakeupBrandRating" />
                        <asp:CommandField AccessibleHeaderText="Actions" ButtonType="Button" HeaderText="Actions" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" />
                    </Columns>
                </asp:GridView>
            </div>


            <div class="grid-view">
                <h2>Makeup Type Table</h2>

                <asp:GridView CssClass="grid" ID="MakeupTypeGrid" runat="server" AutoGenerateColumns="False" OnRowDeleting="MakeupTypeGrid_RowDeleting" OnRowEditing="MakeupTypeGrid_RowEditing">
                    <Columns>
                        <asp:BoundField DataField="MakeupTypeID" HeaderText="ID" SortExpression="MakeupTypeID" />
                        <asp:BoundField DataField="MakeupTypeName" HeaderText="MakeupTypeName" SortExpression="MakeupTypeName" />
                        <asp:CommandField ButtonType="Button" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" HeaderText="Actions" />
                    </Columns>
                </asp:GridView>
            </div>

            <div class="grid-view">
                <h2>Makeup Brands Table</h2>

                <asp:GridView CssClass="grid" ID="MakeupBrandGrid" runat="server" AutoGenerateColumns="False" OnRowDeleting="MakeupBrandGrid_RowDeleting" OnRowEditing="MakeupBrandGrid_RowEditing">
                    <Columns>
                        <asp:BoundField DataField="MakeupBrandID" HeaderText="ID" SortExpression="MakeupBrandID" />
                        <asp:BoundField DataField="MakeupBrandName" HeaderText="MakeupBrandName" SortExpression="MakeupBrandName" />
                        <asp:BoundField DataField="MakeupBrandRating" HeaderText="Rating" SortExpression="MakeupBrandRating" />
                        <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" />
                    </Columns>
                </asp:GridView>
            </div>

        </div>
        <div class="btn-container">
            <asp:Button CssClass="btn" ID="InsertMakeupBtn" runat="server" Text="Insert Makeup" OnClick="InsertPageBtn_Click" />
            <asp:Button CssClass="btn" ID="InsertMakeupTypeBtn" runat="server" Text="Insert Makeup Type" OnClick="InsertMakeupTypeBtn_Click" />
            <asp:Button CssClass="btn" ID="InsertMakeupBrandBtn" runat="server" Text="Insert Brand Type" OnClick="InsertMakeupBrandBtn_Click" />
        </div>
    </div>

</asp:Content>

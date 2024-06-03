<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Projek_Lab_PSD.Views.Home" %>

<asp:Content ID="HomePage" ContentPlaceHolderID="content" runat="server">
    <div class="home-page">
        <div class="username-role-container">
            <h1 class="home-title">Home</h1>

            <p>| Welcome Back @<asp:Label ID="usernameLbl" runat="server" Text=""></asp:Label>!
                | You role is
                <asp:Label ID="roleLbl" runat="server" Text=""></asp:Label></p>
        </div>

        <asp:Label ID="UserOnlineCount" runat="server" Text="0 User(s) Online"></asp:Label>

        <hr />

        <div class="list-grid-container" runat="server" id="ListGridContainer">
            <div class="user-list-container">
                <h1>Users List</h1>

                <asp:ListBox ID="UserList" runat="server" Width="300px"></asp:ListBox>
            </div>

            <div class="grid-view">
                <h2>Customer Data</h2>
                <asp:GridView ID="UsersGrid" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID" />
                        <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                        <asp:BoundField DataField="UserDOB" HeaderText="UserDOB" SortExpression="UserDOB" />
                        <asp:BoundField DataField="UserGender" HeaderText="Gender" SortExpression="UserGender" />
                        <asp:BoundField DataField="UserRole" HeaderText="Role" SortExpression="UserRole" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>


    </div>


</asp:Content>

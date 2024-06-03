<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projek_Lab_PSD.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>

    <link href="/Styles/Login.css" rel="stylesheet" />

    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:ital,wght@0,100..900;1,100..900&display=swap" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">

        <p class="sign-in-lbl">Sign In</p>

        <div class="text-box-lbl">
            <asp:Label ID="UsernameLbl" runat="server" Text="Username" CssClass="lbl"></asp:Label>
            <asp:TextBox ID="UsernameTB" runat="server" CssClass="input" placeholder="e.g OrangGanteng"></asp:TextBox>
        </div>
        <div class="text-box-lbl">
            <asp:Label ID="PasswordLbl" runat="server" Text="Password" CssClass="lbl"></asp:Label>
            <asp:TextBox ID="PasswordTB" runat="server" CssClass="input" placeholder="Password"></asp:TextBox>
        </div>

        <div class="check-box">
            <asp:CheckBox ID="rememberMeCheck" runat="server" />
            <asp:Label ID="rememberMeCheckLbl" runat="server" Text="Remember me"></asp:Label>
        </div>

        <div>
            <asp:Label ID="ErrorLbl" runat="server" Text="" ></asp:Label>
        </div>

        <asp:Button ID="LoginBtn" runat="server" Text="Login" CssClass="login-btn" OnClick="LoginBtn_Click"/>

        <div>
            <p>Don't have an account? <a href="/Views/Register.aspx">Register</a></p>
        </div>
    </form>
</body>
</html>

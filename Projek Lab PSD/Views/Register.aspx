<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Projek_Lab_PSD.Views.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>

    <link href="/Styles/Register.css" rel="stylesheet" />

    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:ital,wght@0,100..900;1,100..900&display=swap" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">

        <p class="sign-up-lbl">Sign Up</p>

        <div class="text-box-lbl">
            <asp:Label ID="UsernameLbl" runat="server" Text="Username" CssClass="lbl"></asp:Label>
            <asp:TextBox ID="UsernameTB" runat="server" CssClass="input" placeholder="e.g OrangGanteng"></asp:TextBox>
        </div>
        <div class="text-box-lbl">
            <asp:Label ID="EmailLbl" runat="server" Text="Email" CssClass="lbl"></asp:Label>
            <asp:TextBox TextMode="Email" ID="EmailTB" runat="server" CssClass="input" placeholder="e.g user@email.com"></asp:TextBox>
        </div>
        <div class="text-box-lbl">
            <asp:Label ID="GenderLbl" runat="server" Text="Gender" CssClass="lbl"></asp:Label>
            <asp:RadioButtonList ID="GenderList" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </div>

        <div class="text-box-lbl">
            <asp:Label ID="PasswordLbl" runat="server" Text="Password" CssClass="lbl"></asp:Label>
            <asp:TextBox TextMode="Password" ID="PasswordTB" runat="server" CssClass="input" placeholder="Password"></asp:TextBox>
        </div>

        <div class="text-box-lbl">
            <asp:Label ID="ConfirmPassLbl" runat="server" Text="Confirm password" CssClass="lbl"></asp:Label>
            <asp:TextBox TextMode="Password" ID="ConfirmPassTB" runat="server" CssClass="input" placeholder="Confirm password"></asp:TextBox>
        </div>

        <div class="text-box-lbl">
            <asp:Label ID="DateOfBirthLbl" runat="server" Text="Date of Birth" CssClass="lbl"></asp:Label>
            <input type="date" id="dob" name="DOB" />
        </div>

        <div>
            <asp:Label ID="ErrorLbl" runat="server" Text="" CssClass="error-lbl"></asp:Label>
        </div>

        <asp:Button ID="RegisterBtn" runat="server" Text="Register" CssClass="register-btn" OnClick="RegisterBtn_Click"/>

        <div>
            <p>Already had an account? <a href="/Views/Login.aspx">Login</a></p>
        </div>
    </form>
</body>
</html>

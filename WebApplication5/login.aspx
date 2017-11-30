<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication5.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Login_label_prompt" runat="server" Text="Please Login"></asp:Label>
            <br />
            <asp:Label ID="Login_error_label" runat="server" ForeColor="Red" Text="Username or password incorrect" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="Username_input" runat="server" AutoCompleteType="DisplayName">Username</asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="Password_input" runat="server" TextMode="Password">********</asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Login_Button" runat="server" OnClick="Login_Button_Click" Text="Login" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Register_Button" runat="server" Text="Register" />
            <br />
        </div>
    </form>
</body>
</html>

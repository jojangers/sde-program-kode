<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="beskeder.aspx.cs" Inherits="WebApplication5.WebForm1" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Tilbage" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Log ud" />
        </p>
        <hr />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>

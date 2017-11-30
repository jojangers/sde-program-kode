<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forum.aspx.cs" Inherits="WebApplication5.forum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <script type = "text/javascript">
        function Confirm() {
            var confirm_value = document.createElement("INPUT");
            confirm_value.type = "hidden";
            confirm_value.name = "confirm_value";
            if (confirm("Er du sikker?")) {
                confirm_value.value = "Yes";
            } else {
                confirm_value.value = "No";
            }
            document.forms[0].appendChild(confirm_value);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Husk at udfylde alle felter!" Visible="False"></asp:Label>
            <br />
            <br />
            navn:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Navn_textbox" runat="server" Width="163px"></asp:TextBox>
            <br />
            <br />
            E_mail:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Mail_textbox" runat="server" Height="16px" Width="163px"></asp:TextBox>
            <br />
            <br />
            besked:<br />
            <asp:TextBox ID="Besked_textbox" runat="server" Height="118px" TextMode="MultiLine" Width="214px"></asp:TextBox>
            <br />
            <br />
            adresse:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Adresse_textbox" runat="server" Width="156px"></asp:TextBox>
            <br />
            <br />
            mobil nr:&nbsp;&nbsp;
            <asp:TextBox ID="Mobil_textbox" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Save_button" runat="server" OnClick="Save_button_Click" Text="Save" />
            <asp:Button ID="Reset_button" runat="server" OnClick="Reset_button_Click" Text="Reset" OnClientClick="Confirm()" />
            <asp:Button ID="Delete_all_button" runat="server" OnClick="Delete_all_button_Click" Text="Delete All Messages" OnClientClick="Confirm()" />
            <asp:Button ID="Read_all_button" runat="server" Text="Read all messages" OnClick="Read_all_button_Click" />
            <br />
            <asp:Button ID="Logout_button" runat="server" OnClick="Logout_button_Click" Text="Logout" />
        </div>
    </form>
</body>
</html>

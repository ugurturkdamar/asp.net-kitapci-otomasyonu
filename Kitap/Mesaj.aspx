<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Mesaj.aspx.cs" Inherits="Mesaj" %>

<!DOCTYPE html>
<script runat="server">
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="KullancıAdı"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label2" runat="server" Text="Konu"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Mesaj"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Height="69px" TextMode="MultiLine" Width="205px"></asp:TextBox>
            &nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Gönder" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

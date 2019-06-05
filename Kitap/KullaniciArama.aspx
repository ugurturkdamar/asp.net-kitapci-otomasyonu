<%@ Page Language="C#" AutoEventWireup="true" CodeFile="KullaniciArama.aspx.cs" Inherits="KullaniciArama" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
        </asp:GridView>
        <br />
        Kullanıcı Adı:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ara" />
    </form>
</body>
</html>

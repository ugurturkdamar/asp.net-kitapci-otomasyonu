<%@ Page Language="C#" AutoEventWireup="true" CodeFile="KullaniciProfilSayfasi.aspx.cs" Inherits="KullaniciProfilSayfasi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    Resim
    <br />
    <img alt="" src="" style="height: 52px; width: 40px" /><br />
    <br />
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        Okuduğu Kitaplar:<br />
                   <asp:ListBox ID="ListBox1" runat="server" Height="104px" Width="156px"  ></asp:ListBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Mesaj Gönder" Width="111px" OnClick="Button1_Click" style="height: 26px" />
        <br />
        <asp:GridView ID="GridView1" runat="server" Height="86px" Width="115px">
        </asp:GridView>
        <br />
        <div>
        </div>
    </form>
</body>
</html>

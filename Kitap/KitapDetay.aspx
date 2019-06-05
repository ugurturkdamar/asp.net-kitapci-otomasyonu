<%@ Page Language="C#" AutoEventWireup="true" CodeFile="KitapDetay.aspx.cs" Inherits="KitapDetay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Kitap Kaydet" />
        </div>
    </form>
</body>
</html>

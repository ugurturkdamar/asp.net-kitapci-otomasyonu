<%@ Page Language="C#" AutoEventWireup="true" CodeFile="YazarArama.aspx.cs" Inherits="YazarArama" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Yazar AdSoyad:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ara" />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Detay" />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            Kitapları:<br />
            <asp:ListBox ID="ListBox1" runat="server" Height="109px" Width="189px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
        </div>
    </form>
</body>
</html>

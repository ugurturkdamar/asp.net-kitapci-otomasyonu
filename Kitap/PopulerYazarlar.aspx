<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PopulerYazarlar.aspx.cs" Inherits="PopulerYazarlar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
        </asp:GridView>
        <asp:ListBox ID="ListBox1" runat="server" Height="104px" Width="156px" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
    </form>
</body>
</html>

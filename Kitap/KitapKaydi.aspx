<%@ Page Language="C#" AutoEventWireup="true" CodeFile="KitapKaydi.aspx.cs" Inherits="KitapKaydi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Alıntı<br />
            <asp:TextBox ID="TextBox2" runat="server" Height="80px" TextMode="MultiLine" Width="270px"></asp:TextBox>
            <br />
            Sayfa No : <asp:TextBox ID="TextBox3" runat="server" Width="31px"></asp:TextBox>
            <br />
            <br />
            İnceleme<br />
            <asp:TextBox ID="TextBox1" runat="server" Height="100px" TextMode="MultiLine" Width="270px"></asp:TextBox>
            <br />
            <br />
            <br />
            Puanlama<br />
            <asp:DropDownList ID="DropDownList1" runat="server" Height="42px" Width="96px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Seçiniz..</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox1" runat="server" Text="OKUDUM" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ekle" Font-Bold="True" />
        </div>
    </form>
</body>
</html>

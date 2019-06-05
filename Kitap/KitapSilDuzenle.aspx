<%@ Page Language="C#" AutoEventWireup="true" CodeFile="KitapSilDuzenle.aspx.cs" Inherits="KitapSilDuzenle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            YazarID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Adi:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Yayinevi:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" Font-Bold="True" OnClick="Button2_Click" Text="Düzenle" />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="KitapID" DataValueField="KitapID">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KitapConnectionString %>" SelectCommand="SELECT * FROM KitaplarTanim"></asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="KitapID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="KitapID" HeaderText="KitapID" ReadOnly="True" SortExpression="KitapID" />
                    <asp:BoundField DataField="YazarID" HeaderText="YazarID" SortExpression="YazarID" />
                    <asp:BoundField DataField="Adi" HeaderText="Adi" SortExpression="Adi" />
                    <asp:BoundField DataField="Yayinevi" HeaderText="Yayinevi" SortExpression="Yayinevi" />
                </Columns>
            </asp:GridView>
            <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click" Text="Sil" />
            <br />
        </div>
    </form>
</body>
</html>

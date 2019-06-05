<%@ Page Language="C#" AutoEventWireup="true" CodeFile="KitapEkle.aspx.cs" Inherits="KitapEkle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KitapConnectionString %>" SelectCommand="SELECT * FROM [KitaplarTanim]"></asp:SqlDataSource>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="KitapID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="KitapID" HeaderText="KitapID" ReadOnly="True" SortExpression="KitapID" />
                    <asp:BoundField DataField="YazarID" HeaderText="YazarID" SortExpression="YazarID" />
                    <asp:BoundField DataField="Adi" HeaderText="Adi" SortExpression="Adi" />
                    <asp:BoundField DataField="Yayinevi" HeaderText="Yayinevi" SortExpression="Yayinevi" />
                </Columns>
            </asp:GridView>
            <br />
            Kitap ID:<br />
            <asp:TextBox ID="TextBox1" runat="server" Width="116px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Boş geçilemez!"></asp:RequiredFieldValidator>
            <br />
            YazarID:<br />
            <asp:TextBox ID="TextBox2" runat="server" Width="152px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="Boş Geçilemez!"></asp:RequiredFieldValidator>
            <br />
            Kitap Adı:<br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Boş Geçilemez!"></asp:RequiredFieldValidator>
            <br />
            Yayın Evi:</div>
        <asp:TextBox ID="TextBox4" runat="server" Width="158px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Boş Geçilemez!"></asp:RequiredFieldValidator>
        <br />
        Resim:<br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Yükle" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click" Text="Ekle" />
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="KullaniciKayit.aspx.cs" Inherits="KullaniciKayit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 223px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Kullanıcı :</strong><br />
            <br />
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">İsim:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Boş Geçilemez!"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Soyisim:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Boş Geçilemez!"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Cinsiyet:</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">DoğumTarihi: </td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">KullanıcıAdı:
            </td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox5" ErrorMessage="Boş Geçilemez!"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Şifre:&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox6" ErrorMessage="Boş Geçilemez!"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Resim:&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        <asp:Button ID="Button2" runat="server" Text="Yükle" OnClick="Button2_Click1" />
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Button ID="Button1" runat="server" Text="Kayıt" OnClick="Button1_Click" Font-Bold="True" style="height: 26px" />
        </div>
    </form>
</body>
</html>

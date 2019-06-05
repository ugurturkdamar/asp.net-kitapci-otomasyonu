<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PopulerKitaplar.aspx.cs" Inherits="PopulerKitaplar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <SelectedRowStyle BackColor="#FF9933" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KitapKaydi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        int KullanıcıID = Convert.ToInt32(Session["KullaniciID"]);
        int KitapID = Convert.ToInt32(Session["KitapID"]);
        if (CheckBox1.Checked)
            DBIslemleri.Okunma(KitapID, KullanıcıID);
        if (TextBox1.Text != "")
            DBIslemleri.Inceleme(TextBox1.Text, KitapID, KullanıcıID);
        if (TextBox2.Text != "" & TextBox3.Text != "")
            DBIslemleri.Alıntı(TextBox2.Text, KitapID, KullanıcıID, Convert.ToInt32(TextBox3.Text));
        if (DropDownList1.SelectedIndex != 0)
            DBIslemleri.Puan(Convert.ToInt32(DropDownList1.SelectedValue), KitapID, KullanıcıID);
        TextBox1.Text = "";
        TextBox2.Text = "";
        DropDownList1.SelectedIndex = 0;
        Response.Write("Eklendi!");

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
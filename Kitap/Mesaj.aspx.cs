using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Mesaj : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = Session["ProfilAdi"].ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DBIslemleri.Gonder(TextBox1.Text, Convert.ToInt32(Session["KullaniciID"].ToString()), TextBox3.Text, TextBox2.Text);
        Response.Write("İletildi!");
        TextBox2.Text = "";
        TextBox3.Text = "";
    }
}
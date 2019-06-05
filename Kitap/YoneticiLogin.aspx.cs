using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class YoneticiLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string mesaj = Request.QueryString["msg"];
        Response.Write(mesaj);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {      
        string k = TextBox1.Text;
        string s = TextBox2.Text;
        bool varMi = DBIslemleri.girisKontrol(k,s);
        if (varMi == false)
            Response.Write("Yanlis KullaniciAdi ve/veya Sifre");
        else
        {
            Session["Giris"] = true;
            Session["Yonetici"] = k;
            Response.Redirect("Yonetici.aspx");

        }
    }
}
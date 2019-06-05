using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class KullaniciLogin : System.Web.UI.Page
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
        int varMi = DBIslemleri.girisKontrol2(k,s);
        if (varMi < 0)
            Response.Write("Yanlis KullaniciAdi ve/veya Sifresi");
        else
        {
            Session["giris"] = true;
            Session["kid"] = k;
            Session["KullaniciID"] = varMi;
            Response.Redirect("Kullanici.aspx");

        }

    }
}
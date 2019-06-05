using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Kullanici : System.Web.UI.Page
{
    public string OneriKullaniciAd;
    public string OneriKullaniciAd2;

    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = DBIslemleri.Oneri1(Session["KullaniciID"].ToString());
        GridView3.DataSource = ds;
        GridView3.DataBind();
        DataSet ds2 = DBIslemleri.Oneri2(Session["KullaniciID"].ToString());
        GridView4.DataSource = ds2;
        GridView4.DataBind();
    }

    protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["ProfilAdi"] = GridView3.Rows[GridView3.SelectedIndex].Cells[1].Text;
        Response.Redirect("KullaniciProfilSayfasi.aspx");
    }

    protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["ProfilAdi"] = GridView4.Rows[GridView4.SelectedIndex].Cells[1].Text;
        Response.Redirect("KullaniciProfilSayfasi.aspx");
    }

}

   
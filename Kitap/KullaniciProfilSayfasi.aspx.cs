using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KullaniciProfilSayfasi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
            string ProfilID = Session["ProfilAdi"].ToString();
            DataSet ds = DBIslemleri.KullaniciAra(ProfilID);
            int a = ds.Tables[0].Rows.Count;
            Label1.Text = ds.Tables[0].Rows[0]["Adi"].ToString();
            Label2.Text = ds.Tables[0].Rows[0]["Soyadi"].ToString();
            DataSet ds2 = DBIslemleri.OkunanKitaplar(ds.Tables[0].Rows[0]["KullaniciID"].ToString());
            ListBox1.DataSource = ds2;
            ListBox1.DataTextField = "Adi";
            ListBox1.DataValueField = "KitapID";
            ListBox1.DataBind();
            DataSet ds3 = DBIslemleri.Değerlendirmeler(ds.Tables[0].Rows[0]["KullaniciID"].ToString());
            GridView1.DataSource = ds3;
            GridView1.DataBind();
          
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        Response.Redirect("Mesaj.aspx");
        
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class KitapSilDuzenle : System.Web.UI.Page
{
    public static string baglantiYolu = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Turkishvein\Documents\Kitap.mdf;Integrated Security=True;Connect Timeout=30";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Convert.ToBoolean(Session["Giris"]) != true)
            Response.Redirect("YoneticiLogin.aspx?msg=Oncelikle giris yapmalisiniz");
    }
   

    protected void Button1_Click(object sender, EventArgs e)
    {
        string sql = "DELETE  FROM KitaplarTanim WHERE KitapID=@kID";
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        SqlCommand komut = new SqlCommand(sql, baglanti);
        komut.Parameters.AddWithValue("@kID", Convert.ToInt32(DropDownList1.SelectedValue));
             
            baglanti.Open();
            komut.ExecuteNonQuery();
            Response.Write("Silindi!");
       
            baglanti.Close();
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string sql = "UPDATE KitaplarTanim SET YazarID=@yID,Adi=@a,Yayinevi=@y WHERE KitapID=@kID";
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        SqlCommand komut = new SqlCommand(sql, baglanti);
        komut.Parameters.AddWithValue("@yID",Convert.ToInt32(TextBox1.Text));
        komut.Parameters.AddWithValue("@a",TextBox2.Text);
        komut.Parameters.AddWithValue("@y",TextBox3.Text);
        komut.Parameters.AddWithValue("@kID", DropDownList1.SelectedValue);
        baglanti.Open();
        komut.ExecuteNonQuery();
        Response.Write("Düzenlendi!");

        baglanti.Close();
    }
}
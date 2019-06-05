using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class KitapEkle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Convert.ToBoolean(Session["Giris"]) != true)
            Response.Redirect("YoneticiLogin.aspx?msg=Oncelikle giris yapmalisiniz");
    }

    public static string baglantiYolu = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Turkishvein\Documents\Kitap.mdf;Integrated Security=True;Connect Timeout=30";

    protected void Ekle()
    {
        string sql = "INSERT INTO KitaplarTanim(KitapID,YazarID,Adi,Yayinevi) VALUES(@kID,@yID,@a,@y)";
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        SqlCommand komut = new SqlCommand(sql, baglanti);
        komut.Parameters.AddWithValue("@kID", Convert.ToInt32(TextBox1.Text));
        komut.Parameters.AddWithValue("@yID", Convert.ToInt32(TextBox2.Text));
        komut.Parameters.AddWithValue("@a", TextBox3.Text);
        komut.Parameters.AddWithValue("@y", TextBox4.Text);
        try
        {
            baglanti.Open();
            komut.ExecuteNonQuery();
            Response.Write("Eklendi!");
        }
        catch (Exception ex)
        {
            Response.Write("Hata: "+ex.Message);
        }
        finally
        {
            baglanti.Close(); 
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Ekle();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            if (FileUpload1.PostedFile.ContentType == "image/jpeg")
            {
                if (FileUpload1.PostedFile.ContentLength < 1024000)
                {
                    string isim = Guid.NewGuid().ToString();

                    FileUpload1.SaveAs(Server.MapPath("~/resimler/") + isim + ".jpeg");     
                    Label1.Text = "Dosya yüklendi. Alınan dosyanın detayları:<br>" +
                         "Dosya Türü:" + FileUpload1.PostedFile.ContentType + "<br>" +
                         "Dosya Boyutu:" + FileUpload1.PostedFile.ContentLength;

                }
                else
                    Label1.Text = "Dsya boyutu maximum 1MB olmalıdır.";
            }
            else
                Label1.Text = "Sadece jpeg uzantılı dosyalar yüklenebilir.";
        }
        else
            Label1.Text = "Lütfen bir dosya seçiniz.";
    }
}
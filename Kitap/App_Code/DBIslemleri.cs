using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class DBIslemleri
{

    public static string baglantiYolu = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Turkishvein\Documents\Kitap.mdf;Integrated Security=True;Connect Timeout=30";

    public static DataSet Eslestir(string k)
    {
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        string sql = "SELECT KitapID FROM KitapOkunma WHERE KullaniciID=@k";
        SqlCommand komut = new SqlCommand(sql, baglanti);
        komut.Parameters.AddWithValue("@k", k);
        DataSet sonucDS = new DataSet();
        SqlDataAdapter adaptor = new SqlDataAdapter();
        adaptor.SelectCommand = komut;
        baglanti.Open();
        adaptor.Fill(sonucDS);
        baglanti.Close();
        return sonucDS;
    }

    public static bool girisKontrol(string k,string s)
    {
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        string sql = "SELECT * FROM YoneticiTanim WHERE KullaniciAdi=@k AND Sifre=@s";
        SqlCommand komut = new SqlCommand(sql, baglanti);
        komut.Parameters.AddWithValue("@k", k);
        komut.Parameters.AddWithValue("@s", s);
        DataSet sonucDS = new DataSet();
        SqlDataAdapter adaptor = new SqlDataAdapter();
        adaptor.SelectCommand = komut;
        baglanti.Open();
        adaptor.Fill(sonucDS);
        baglanti.Close();
        bool sonuc = false;
        if (sonucDS.Tables[0].Rows.Count > 0)
            sonuc = true;
        else
            sonuc = false;
        return sonuc;
    }
    public static int girisKontrol2(string k, string s)
    {
        SqlConnection baglan = new SqlConnection(baglantiYolu);
        string sql = " SELECT * from KullanicilarTanim where KullaniciAdi = @k and Sifre = @s";
        SqlCommand komut = new SqlCommand(sql, baglan);
        komut.Parameters.AddWithValue("@k", k);
        komut.Parameters.AddWithValue("@s", s);
        DataSet sonucDS = new DataSet();
        SqlDataAdapter adaptor = new SqlDataAdapter();
        adaptor.SelectCommand = komut;
        baglan.Open();
        adaptor.Fill(sonucDS);
        baglan.Close();       
        if (sonucDS.Tables[0].Rows.Count > 0)
        {
            string yazi = sonucDS.Tables[0].Rows[0].ItemArray[0].ToString();
            return Convert.ToInt32(yazi);
        }
        else
            return -1;

    }

    public static DataSet KitaplariCek()
    {
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        string sql = "SELECT * FROM KitaplarTanim";
        SqlCommand komut = new SqlCommand(sql, baglanti);
        SqlDataAdapter adaptor = new SqlDataAdapter();
        adaptor.SelectCommand = komut;
        DataSet kitaplarDS = new DataSet();
        baglanti.Open();
        adaptor.Fill(kitaplarDS);
        baglanti.Close();
        return kitaplarDS;
    }   
    public static void KitapSil(int kID)
    {
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        string sql = "DELETE * FROM KitaplarTanim WHERE KitapID=@kID";
        SqlCommand komut = new SqlCommand(sql, baglanti);
        komut.Parameters.AddWithValue("@kID", kID);
        baglanti.Open();
        komut.ExecuteNonQuery();
        baglanti.Close();
    }
   
    public static void KitapDuzenle(int ykID,string yAdi,string yYevi)
    {
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        string sql = "UPDATE KitaplarTanim(Adi,Yayinevi) SET Adi=@yAdi,Yayinevi=@yYevi WHERE KitapID=@ykID";
        SqlCommand komut = new SqlCommand(sql, baglanti);
        komut.Parameters.AddWithValue("@yAdi", yAdi);
        komut.Parameters.AddWithValue("@yYevi", yYevi);
        komut.Parameters.AddWithValue("@ykID", ykID);
        baglanti.Open();
        komut.ExecuteNonQuery();
        baglanti.Close();
    }
    public static DataSet Bul(string isim)
    {
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        string sql = "SELECT * FROM KitaplarTanim WHERE Adi like @a+'%'";
        SqlCommand komut = new SqlCommand(sql, baglanti);
        komut.Parameters.AddWithValue("@a", isim);
        SqlDataAdapter adaptor = new SqlDataAdapter();
        adaptor.SelectCommand = komut;
        DataSet sonucDS = new DataSet();
        baglanti.Open();
        adaptor.Fill(sonucDS);
        baglanti.Close();
        return sonucDS;
    }
    public static DataSet Değerlendirmeler(string KullaniciID)
    {
        SqlConnection baglan = new SqlConnection(baglantiYolu);
        string sql = "select Adi,Cumle as Alıntı,KitapInceleme.KitapInceleme as İnceleme,Puan from KitapAlinti inner join KitapInceleme on KitapAlinti.KitapID = KitapInceleme.KitapID inner join KitapPuan on KitapAlinti.KitapID = KitapPuan.KitapID inner join KitaplarTanim on KitapAlinti.KitapID = KitaplarTanim.KitapID where KitapAlinti.KullaniciID =" + KullaniciID;
        SqlCommand komut = new SqlCommand(sql, baglan);
        SqlDataAdapter adaptor = new SqlDataAdapter();
        adaptor.SelectCommand = komut;
        DataSet sonucDS = new DataSet();
        baglan.Open();
        adaptor.Fill(sonucDS);
        baglan.Close();
        return sonucDS;
    }
    public static DataSet OkunanKitaplar(string KullaniciID)
    {
        SqlConnection baglan = new SqlConnection(baglantiYolu);
        string sql = "select Adi,KitapOkunma.KitapID as KitapID from KitaplarTanim inner join KitapOkunma on KitapOkunma.KitapID = KitaplarTanim.KitapID where KitapOkunma.KullaniciID = " + KullaniciID;
        SqlCommand komut = new SqlCommand(sql, baglan);
        SqlDataAdapter adaptor = new SqlDataAdapter();
        adaptor.SelectCommand = komut;
        DataSet sonucDS = new DataSet();
        baglan.Open();
        adaptor.Fill(sonucDS);
        baglan.Close();
        return sonucDS;
    }

    public static DataSet KullaniciAra(string BaskaKullaniciAdi)
    {
        SqlConnection baglan = new SqlConnection(baglantiYolu);
        string sql = "select KullaniciID,Adi,Soyadi,Cinsiyet,KullaniciAdi from KullanicilarTanim where KullaniciAdi like @kadi";
        SqlCommand komut = new SqlCommand(sql, baglan);
        komut.Parameters.AddWithValue("@kadi", BaskaKullaniciAdi + "%");
        SqlDataAdapter adaptor = new SqlDataAdapter();
        adaptor.SelectCommand=komut;
        DataSet sonucDS = new DataSet();
        baglan.Open();
        adaptor.Fill(sonucDS);
        baglan.Close();
        return sonucDS;

    }
    public static DataSet YazarARAID(string yID)
    {
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        string sql = "SELECT AdiSoyadi as AdiSoyadi,Detay,DogumTarihi,DogumYeri,OlumTarihi FROM YazarlarTanim WHERE YazarID=@y";
        SqlCommand komut = new SqlCommand(sql, baglanti);
        komut.Parameters.AddWithValue("@y", yID);
        SqlDataAdapter adaptor = new SqlDataAdapter();
        adaptor.SelectCommand = komut;
        DataSet sonucDS = new DataSet();
        baglanti.Open();
        adaptor.Fill(sonucDS);
        baglanti.Close();
        return sonucDS;
    }

    public static DataSet YazarIDAra(string Kid)
    {
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        string sql = "select * from KitaplarTanim where YazarID=@kadi";
        SqlCommand komut = new SqlCommand(sql, baglanti);
        komut.Parameters.AddWithValue("@kadi", Kid);
        SqlDataAdapter adaptor = new SqlDataAdapter();
        adaptor.SelectCommand = komut;
        DataSet sonucDS = new DataSet();
        baglanti.Open();
        adaptor.Fill(sonucDS);
        baglanti.Close();
        return sonucDS;
    }
    public static DataSet Ara(string k)
    {
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        string sql = "select * from KitaplarTanim where Adi like @k";
        SqlCommand komut = new SqlCommand(sql, baglanti);
        komut.Parameters.AddWithValue("@k",k+"%");
        SqlDataAdapter adaptor = new SqlDataAdapter();
        adaptor.SelectCommand = komut;
        DataSet sonucDS = new DataSet();
        baglanti.Open();
        adaptor.Fill(sonucDS);
        baglanti.Close();
        return sonucDS;
    }
    public static DataSet IDAra(int k)
    {
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        string sql = "select * from KitaplarTanim where KitapID = @k";
        SqlCommand komut = new SqlCommand(sql, baglanti);
        komut.Parameters.AddWithValue("@k",k);
        SqlDataAdapter adaptor = new SqlDataAdapter();
        adaptor.SelectCommand = komut;
        DataSet sonucDS = new DataSet();
        baglanti.Open();
        adaptor.Fill(sonucDS);
        baglanti.Close();
        return sonucDS;
    }
    public static DataSet KullaniciARA(string BaskaKullaniciAdi)
    {
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        string sql = "select KullaniciID,Adi,Soyadi,Cinsiyet,KullaniciAdi from KitaplarTanim where Adi like @kadi";
        SqlCommand komut = new SqlCommand(sql, baglanti);
        komut.Parameters.AddWithValue("@kadi", BaskaKullaniciAdi+"%");
        SqlDataAdapter adaptor = new SqlDataAdapter();
        adaptor.SelectCommand = komut;
        DataSet sonucDS = new DataSet();
        baglanti.Open();
        adaptor.Fill(sonucDS);
        baglanti.Close();
        return sonucDS;
    }
    public static DataSet YazarARA(string yazarAdi)
    {
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        string sql = "select YazarID,AdiSoyadi from YazarlarTanim where AdiSoyadi like @yadi";
        SqlCommand komut = new SqlCommand(sql, baglanti);
        komut.Parameters.AddWithValue("@yadi", yazarAdi+"%");
        SqlDataAdapter adaptor = new SqlDataAdapter();
        adaptor.SelectCommand = komut;
        DataSet sonucDS = new DataSet();
        baglanti.Open();
        adaptor.Fill(sonucDS);
        baglanti.Close();
        return sonucDS;
    }  
    public static void Gonder(String kullaniciAdi,int gonderenID, string mesajBasligi,string mesaj)
    {
        
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        string sql = "insert into Mesajlar values('" + gonderenID + "',(select KullaniciID from KullanicilarTanim where KullaniciAdi = '" + kullaniciAdi + "'),'" + mesajBasligi + "','" + mesaj + "',getdate())";
        SqlCommand komut = new SqlCommand(sql, baglanti);
        baglanti.Open();
        komut.ExecuteNonQuery();
        baglanti.Close();
    }
    public static DataSet GelenMesajlar(string kullaniciid)
    {
        SqlConnection baglan = new SqlConnection(baglantiYolu);
        string sql = "select (select KullaniciAdi from KullanicilarTanim where KullaniciID = Mesajlar.GonderenID) as Gönderen ,Baslik,Mesaj,Tarih from Mesajlar where GidenID='" + kullaniciid + "'";
        SqlCommand komut = new SqlCommand(sql, baglan); ;
        SqlDataAdapter adaptor = new SqlDataAdapter();
        adaptor.SelectCommand = komut;
        DataSet sonucDS = new DataSet();
        baglan.Open();
        adaptor.Fill(sonucDS);
        baglan.Close();
        return sonucDS;

    }
    public static void Inceleme(String Inceleme, int KitapID, int KullaniciID)
    {
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        string sql = "insert into KitapInceleme values('" + KullaniciID + "','" + KitapID + "','" + Inceleme + "')";
        SqlCommand komut = new SqlCommand(sql, baglanti);
        baglanti.Open();
        komut.ExecuteNonQuery();
        baglanti.Close();
    }
    public static void Alıntı(String Cumle, int KitapID, int KullaniciID, int SayfaNo)
    {
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        string sql = "insert into KitapAlinti values('" + KullaniciID + "','" + KitapID + "','" + SayfaNo + "','" + Cumle + "')";
        SqlCommand komut = new SqlCommand(sql, baglanti);
        baglanti.Open();
        komut.ExecuteNonQuery();
        baglanti.Close();
    }
    public static void Puan(int Puan,int KitapID,int KullaniciID)
    {
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        string sql = "insert into KitapPuan values('" + KullaniciID + "','" + KitapID + "','"  +Puan+ "')";
        SqlCommand komut = new SqlCommand(sql, baglanti);
        baglanti.Open();
        komut.ExecuteNonQuery();
        baglanti.Close();
    }
    public static void Okunma(int KitapID,int KullaniciID)
    {
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        string sql = "insert into KitapOkunma values('" + KullaniciID + "','" + KitapID + "')";
        string sql2="update KitaplarTanim set OkunmaSayisi+=1 where KitapID='"+KitapID+"'";
        SqlCommand komut = new SqlCommand(sql, baglanti);
        SqlCommand komut2 = new SqlCommand(sql2, baglanti);
        baglanti.Open();
        komut.ExecuteNonQuery();
        komut2.ExecuteNonQuery();
        baglanti.Close();
    }
    public static DataSet PopulerKitaplar()
    {
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        string sql = "select KitapID,Adi,OkunmaSayisi from KitaplarTanim order by OkunmaSayisi DESC";
        SqlCommand komut = new SqlCommand(sql,baglanti);
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = komut;
        DataSet sonucDS = new DataSet();
        baglanti.Open();
        adapter.Fill(sonucDS);
        baglanti.Close();
        return sonucDS;
    }
    public static DataSet YuksekPuanlıKitaplar()
    {
        SqlConnection baglan = new SqlConnection(baglantiYolu);
        string sql = "select sum(Puan) as Puan,Adi,avg(Puan) as 'Ortalama' from KitaplarTanim inner join KitapPuan on KitapPuan.KitapID = KitaplarTanim.KitapID group by KitaplarTanim.Adi order by sum(Puan) DESC";
        SqlCommand komut = new SqlCommand(sql, baglan);
        SqlDataAdapter adaptor = new SqlDataAdapter();
        adaptor.SelectCommand = komut;
        DataSet sonucDS = new DataSet();
        baglan.Open();
        adaptor.Fill(sonucDS);
        baglan.Close();
        return sonucDS;
    }
    public static DataSet PopulerYazarlar()
    {
        SqlConnection baglanti = new SqlConnection(baglantiYolu);
        string sql = "select KitaplarTanim.YazarID,(select AdiSoyadi from YazarlarTanim where YazarlarTanim.YazarID=KitaplarTanim.YazarID),sum(OkunmaSayisi) as Popülarite from KitaplarTanim inner join YazarlarTanim on YazarlarTanim.YazarID=KitaplarTanim.YazarID group by KitaplarTanim.YazarID order by sum(OkunmaSayisi) DESC";
        SqlCommand komut = new SqlCommand(sql, baglanti);
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = komut;
        DataSet sonucDS = new DataSet();
        baglanti.Open();
        adapter.Fill(sonucDS);
        baglanti.Close();
        return sonucDS;
    }

    public static DataSet Oneri1(string KullaniciID)
    {
        SqlConnection baglan = new SqlConnection(baglantiYolu);
        string sql = "select distinct (select distinct KullaniciAdi  from KullanicilarTanim X where  X.KullaniciID=Y.KullaniciID ) as Adı , Y.KullaniciID, count(Y.KullaniciID) as 'Ortak Okunan Kitap Sayısı' from(select B.KullaniciID, A.KitapID from KitapOkunma A  inner join KitapOkunma B ON B.KitapID = A.KitapID and A.KullaniciID <> B.KullaniciID where A.KullaniciID = '" + KullaniciID + "')Y group by Y.KullaniciID  having count(Y.KullaniciID) >0 order by count(Y.KullaniciID)  DESC";
        SqlCommand komut = new SqlCommand(sql, baglan);
        SqlDataAdapter adaptor = new SqlDataAdapter();
        adaptor.SelectCommand = komut;
        DataSet sonucAra = new DataSet();
        baglan.Open();
        adaptor.Fill(sonucAra);
        baglan.Close();
        return sonucAra;
    }
    public static DataSet Oneri2(string KullaniciID)
    {
        SqlConnection baglan = new SqlConnection(baglantiYolu);
        string sql = "select distinct (select distinct KullaniciAdi  from KullanicilarTanim X where  X.KullaniciID=Y.KullaniciID ) as Adı , count(Y.KullaniciID) as 'Ortak Puan Verme Sayısı' from(select B.KullaniciID, A.KitapID from KitapPuan A  inner join KitapPuan B ON B.KitapID = A.KitapID and A.KullaniciID <> B.KullaniciID and A.Puan = B.Puan where A.KullaniciID = '" + KullaniciID + "')Y group by Y.KullaniciID having count(Y.KullaniciID) >0 order by count(Y.KullaniciID)  DESC";
        SqlCommand komut = new SqlCommand(sql, baglan);
        SqlDataAdapter adaptor = new SqlDataAdapter();
        adaptor.SelectCommand = komut;
        DataSet sonucAra = new DataSet();
        baglan.Open();
        adaptor.Fill(sonucAra);
        baglan.Close();
        return sonucAra;
    }

}
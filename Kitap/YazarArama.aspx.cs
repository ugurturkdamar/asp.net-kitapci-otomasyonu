using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class YazarArama : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // Response.Redirect("YazarDetay.aspx?Yara="+TextBox1.Text);
        DataSet bulunanlar = DBIslemleri.YazarARA(TextBox1.Text);
        DropDownList1.DataSource = bulunanlar.Tables[0];
        DropDownList1.DataTextField = "AdiSoyadi";
        DropDownList1.DataValueField = "YazarID";
        DropDownList1.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        DataSet bulunanlar = DBIslemleri.YazarARAID(DropDownList1.SelectedValue);
        GridView1.DataSource = bulunanlar.Tables[0];
        GridView1.DataBind();
        DataSet Kitaplar = DBIslemleri.YazarIDAra(DropDownList1.SelectedValue);
        ListBox1.DataSource = Kitaplar;
        ListBox1.DataTextField = "Adi";
        ListBox1.DataValueField = "KitapID";
        ListBox1.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["KitapID"] = ListBox1.SelectedValue;
        Response.Redirect("KitapDetay.aspx");
    }
}
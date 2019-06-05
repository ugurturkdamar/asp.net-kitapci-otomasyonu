using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class PopulerYazarlar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       

        DataSet ds = DBIslemleri.PopulerYazarlar();
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();

    }
    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        DataSet ds2 = DBIslemleri.YazarIDAra(GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text);
        ListBox1.DataSource = ds2;
        ListBox1.DataTextField = "Adi";
        ListBox1.DataValueField = "KitapID";
        ListBox1.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["KitapID"] = ListBox1.SelectedValue;
        Response.Redirect("KitapDetay.aspx");
    }


    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
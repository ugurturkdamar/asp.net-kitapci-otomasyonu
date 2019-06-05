using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Karama11 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Focus();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSet bulunanlar = DBIslemleri.Ara(TextBox1.Text);
        GridView1.DataSource = bulunanlar.Tables[0];
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        Session["KitapID"] = GridView1.SelectedRow.Cells[1].Text;
        Response.Redirect("KitapDetay.aspx");
    }
}
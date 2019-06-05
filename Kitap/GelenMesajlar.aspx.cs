using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class gelenmesajlar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = DBIslemleri.GelenMesajlar(Session["KullaniciID"].ToString());
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["ProfilAdi"] = GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text;
        Response.Redirect("mesaj.aspx");
    }
}
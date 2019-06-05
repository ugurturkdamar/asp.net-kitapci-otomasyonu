using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class KitapDetay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet b = DBIslemleri.IDAra(Convert.ToInt32(Session["KitapID"].ToString()));
        GridView1.DataSource = b.Tables[0];
        GridView1.DataBind();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("KitapKaydi.aspx");
    }
}
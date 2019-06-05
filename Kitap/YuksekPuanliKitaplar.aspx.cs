using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class YuksekPuanliKitaplar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        DataSet ds = DBIslemleri.YuksekPuanlıKitaplar();
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class PopulerKitaplar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet bulunanlar = DBIslemleri.PopulerKitaplar();
        GridView1.DataSource = bulunanlar.Tables[0];
        GridView1.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["KitapID"] = GridView1.SelectedRow.Cells[1].Text;
        Response.Redirect("KitapDetay.aspx");
    }
}
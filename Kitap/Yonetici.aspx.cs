using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Yonetici : System.Web.UI.Page
{

    

    protected void Page_Load(object sender, EventArgs e)
    {
        if(Convert.ToBoolean(Session["Giris"]) != true)
                Response.Redirect("YoneticiLogin.aspx?msg=Oncelikle giris yapmalisiniz");
    }
}
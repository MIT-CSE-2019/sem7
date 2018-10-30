using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Result : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = HttpUtility.UrlDecode( Request.QueryString["Model"]);
        Label2.Text = HttpUtility.UrlDecode(Request.QueryString["Make"]);
    }
}
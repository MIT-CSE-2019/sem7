using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int counter;
        if (ViewState["count"] == null)
            counter = 1;
        else
            counter = (int)ViewState["count"] + 1;
        ViewState["count"] = counter;
        labelCounter.Text = "click count : " + counter.ToString();
    }
}
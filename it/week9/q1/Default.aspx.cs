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
        if (!IsPostBack)
        {
            List<string> fruits = new List<string>();
            fruits.Add("APPLE");
            fruits.Add("MANGO");
            fruits.Add("ORANGE");
            fruits.Add("GUAVA");
            fruits.Add("QWERTY");

            List<string> ic = new List<string>();
            ic.Add("VANILLA");
            ic.Add("CHOCOLATE");
            ic.Add("BUTTERSCOTCH");
            ic.Add("YUIOP");

            CheckBoxList1.DataSource = fruits;
            RadioButtonList1.DataSource = ic;
            this.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = CheckBoxList1.SelectedValue + " " + RadioButtonList1.SelectedValue + " Rs.123";
    }
}
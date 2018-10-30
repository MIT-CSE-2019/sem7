using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private int count;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            count = 0;
            TextBox1.Text = "0";
        }
        else
        {
            count = Convert.ToInt32(TextBox1.Text);
        }
            
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox2.Text != "abcd")
        {
            count++;
            TextBox1.Text = Convert.ToString(count);
        }
        else 
            TextBox1.Text = Convert.ToString(0);

        if (count==3)
        {
            TextBox2.Enabled = false;
        }
    }
}
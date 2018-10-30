using System;
using System.Collections.Generic;
using System.Drawing;
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
        int flag = 0;

        string s = TextBox1.Text.ToString();
        for(int i =0;i<s.Length;i++)
        {
            if (s[i] >= 'a' && s[i] <= 'z'|| s[i] >= 'A' && s[i] <= 'Z')
                flag = 1;
        }
        int a;
        int.TryParse(TextBox2.Text.ToString(), out a);
        if (a < 1 || a > 150)
            flag = 0;


        if(flag==0)
        {
            TextBox1.BackColor = Color.Red;
            TextBox2.BackColor = Color.Red;
            Button1.BackColor = Color.Gray;
        }
        else
        {
            TextBox1.BackColor = Color.Cyan;
            TextBox2.BackColor = Color.Cyan;
            Button1.BackColor = Color.Cyan;
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if(!IsPostBack)
        {
            foreach(FontFamily f in FontFamily.Families)
                DropDownList2.Items.Add(f.Name);
            foreach (string color in Enum.GetNames(typeof(KnownColor)))
                DropDownList1.Items.Add(color);
            TextBox1.Text = "28";
            RadioButtonList1.Items.Add(new ListItem("None"));
            RadioButtonList1.Items.Add(new ListItem("Double"));
            RadioButtonList1.Items.Add(new ListItem("Solid"));
            RadioButtonList1.SelectedIndex = 2;
            Panel2.BackColor = Color.SeaShell;
            Image1.ImageUrl = "bg.jpeg";

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox2.Font.Name = DropDownList2.SelectedItem.Text;
        TextBox2.Font.Size = Convert.ToInt32(TextBox1.Text);
        Panel2.BackColor = Color.FromName(DropDownList1.SelectedItem.Text);
        Panel2.BackColor = Color.FromKnownColor((KnownColor) Enum.Parse(typeof(KnownColor),DropDownList1.SelectedItem.Text));

        Panel2.BorderStyle = (BorderStyle)Enum.Parse(typeof(BorderStyle), RadioButtonList1.SelectedItem.ToString());
        TextBox2.Text = TextBox3.Text;
        //if(CheckBox1.)



    }
}
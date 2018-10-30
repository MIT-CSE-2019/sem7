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
        if(!IsPostBack)
        {
            DropDownList1.Items.Add(new ListItem("Mobiles"));
            DropDownList1.Items.Add(new ListItem("Laptops"));
            DropDownList1.Items.Add(new ListItem("Printers"));
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string s = DropDownList1.SelectedItem.ToString();
        DropDownList2.Items.Clear();
        switch(s)
        {
            case "Mobiles":
                DropDownList2.Items.Add(new ListItem("Samsung"));
                DropDownList2.Items.Add(new ListItem("Xiaomi"));
                DropDownList2.Items.Add(new ListItem("Apple"));
                break;
                case "Laptops":
                DropDownList2.Items.Add(new ListItem("Lenovo"));
                DropDownList2.Items.Add(new ListItem("Dell"));
                DropDownList2.Items.Add(new ListItem("HP"));
                break;
                case "Printers":
                DropDownList2.Items.Add(new ListItem("HP"));
                DropDownList2.Items.Add(new ListItem("Cannon"));
                DropDownList2.Items.Add(new ListItem("Epson"));
                break;
                

        }
    }
}
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
            ddlSubjects.Items.Add(new ListItem("Maths"));
            ddlSubjects.Items.Add(new ListItem("Physics"));
            ddlSubjects.Items.Add(new ListItem("Biology"));
            ddlSubjects.Items.Add(new ListItem("Chemistry"));
            ddlSubjects.Items.Add(new ListItem("English"));
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Student s = new Student();
        s.Name = TxtName.Text.ToString();
        s.Roll = Convert.ToInt32(TxtRoll.Text.ToString());
        s.Subject = ddlSubjects.SelectedItem.ToString();
        Session["stud"] = s;
        Response.Redirect("Result.aspx");


    }
}
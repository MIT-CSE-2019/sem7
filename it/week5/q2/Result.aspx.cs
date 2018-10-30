using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Result : System.Web.UI.Page
{
    HttpCookie prefCookie;
    protected void Page_Load(object sender, EventArgs e)
    {
        prefCookie = Request.Cookies["Pref"];
        if (prefCookie == null)
        {
            prefCookie = new HttpCookie("Pref");
        }
        Student s = (Student)Session["stud"];
        

        if (!IsPostBack)
        {
            if (s != null)
                Label1.Text = "Name : " + s.Name + " Roll : " + s.Roll.ToString() + " Sub : " + s.Subject;
            Label2.Text = prefCookie["count"];
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int c;
        int.TryParse(Label2.Text.ToString(), out c);
        prefCookie["count"] = (c+1).ToString();
        prefCookie.Expires = DateTime.Now.AddDays(360);
        Response.Cookies.Add(prefCookie);

        Label2.Text = prefCookie["count"];
    }
}
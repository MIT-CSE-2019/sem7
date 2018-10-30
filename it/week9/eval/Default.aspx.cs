using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            String cs = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Eval;Integrated Security=True;Pooling=False";
            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT name FROM Theme";
                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    while(rd.Read())
                    {
                        ddl_themes.Items.Add(rd["name"].ToString());
                    }
                }
            }


        }
    }

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = Session["Theme"].ToString();
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["Theme"] = ddl_themes.SelectedValue.ToString();
        Server.Transfer(Request.FilePath);
    }
}
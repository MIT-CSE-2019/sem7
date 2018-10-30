using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{ static string connectionString;
    static _Default()
        {

        string connectionString = ConfigurationManager.ConnectionStrings["ProductDb"].ConnectionString;
        }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String cs = @"Data Source = (localdb)\MSSQLlocalDB; Initial Catalog = Products; Integrated Security = True; Pooling = False";
        using (SqlConnection con = new SqlConnection(cs))
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                
                cmd.CommandText = "INSERT INTO WORKS(person_name,company_name,salary) VALUES (@a,@c,@s)";
                cmd.Parameters.AddWithValue("@a", pname.Text);
                cmd.Parameters.AddWithValue("@c", cname.Text);
                cmd.Parameters.AddWithValue("@s", sal.Text);
                cmd.Connection = con;
                con.Open();

                cmd.ExecuteNonQuery();
                pname.Text = String.Empty;
                cname.Text = String.Empty;
                sal.Text = String.Empty;



            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        String cs = @"Data Source = (localdb)\MSSQLlocalDB; Initial Catalog = Products; Integrated Security = True; Pooling = False";
        using (SqlConnection con = new SqlConnection(cs))
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT w.person_name,city from WORKS w,LIVES l where company_name=@company  and w.person_name=l.person_name;";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@company", txtCname.Text);
                con.Open();

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Label1.Text += rd["person_name"].ToString() + " " + rd["city"].ToString() + "<br/>";
                }
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    static string connectionString;
    static _Default()
    {

        connectionString = WebConfigurationManager.ConnectionStrings["House"].ConnectionString;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT DISTINCT StaffID from Staff";
                    cmd.Connection = con;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(ds, "Staff");
                    foreach (DataRow row in ds.Tables["Staff"].Rows)
                    {
                        DropDownList1.Items.Add(row["StaffID"].ToString());

                    }
                    ListBox1.Items.Add("Patna");
                    ListBox1.Items.Add("Manipal");
                    ListBox1.Items.Add("Kolkata");
                    ListBox1.Items.Add("London");
                    ListBox1.Items.Add("Delhi");
                }
            }
        }
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        using (SqlConnection con = new SqlConnection(connectionString))
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                
                cmd.CommandText = "UPDATE Staff SET city=@c WHERE StaffId = @s";
                cmd.Parameters.AddWithValue("@c", ListBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@s", DropDownList1.SelectedValue);

                cmd.Connection = con;
                con.Open();

                cmd.ExecuteNonQuery();
                

            }
        }

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label1.Text = String.Empty;
        using (SqlConnection con = new SqlConnection(connectionString))
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT * from Staff WHERE StaffID = @s";
                cmd.Parameters.AddWithValue("@s", DropDownList1.SelectedValue);
                cmd.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(ds, "Staff");
                foreach (DataRow row in ds.Tables["Staff"].Rows)
                {
                    Label1.Text += row["StaffID"] + "<br/>" +
                                        row["FirstName"] + " <br/>" +
                                       row["LastName"] + " <br/>" +
                                        //   row["DNo"] + " <br/>" +
                                        // row["Street"] + " <br/>" +
                                        row["City"] + " <br/>" +
                                       row["State"] + " <br/>";
                                   //    row["ZipCode"] + " <br/>";
                    

                }
            }
        }
    }
}
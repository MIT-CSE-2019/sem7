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

    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        lblDisplay.Text = String.Empty;
        String cs = @"Data Source = (localdb)\MSSQLlocalDB; Initial Catalog = Products; Integrated Security = True; Pooling = False";
        using (SqlConnection con = new SqlConnection(cs))
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT * FROM ITEMS";
                cmd.Connection = con;
                con.Open();

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lblDisplay.Text += rd["itemId"].ToString() + " " + rd["flavour"].ToString() +" "+ rd["price"].ToString() + "<br/>";
                }
            }
        }
        
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        String cs = @"Data Source = (localdb)\MSSQLlocalDB; Initial Catalog = Products; Integrated Security = True; Pooling = False";
        using (SqlConnection con = new SqlConnection(cs))
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                //cmd.CommandText = "INSERT INTO Items(ItemId,flavour) VALUES ("+ txtItemid.Text + ",'"+txtFlavour.Text+"')";
                cmd.CommandText = "INSERT INTO Items(ItemId,flavour) VALUES (@id,@flavor)";
                cmd.Parameters.AddWithValue("@id",txtItemid.Text);
                cmd.Parameters.AddWithValue("@flavor",txtFlavour.Text.ToString());
                cmd.Connection = con;
                con.Open();
                
                cmd.ExecuteNonQuery();
                txtItemid.Text = String.Empty;
                txtFlavour.Text = String.Empty;


            }
        }
    }

    protected void updateVanilla_Click(object sender, EventArgs e)
    {
        String cs = @"Data Source = (localdb)\MSSQLlocalDB; Initial Catalog = Products; Integrated Security = True; Pooling = False";
        using (SqlConnection con = new SqlConnection(cs))
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                //cmd.CommandText = "INSERT INTO Items(ItemId,flavour) VALUES ("+ txtItemid.Text + ",'"+txtFlavour.Text+"')";
                cmd.CommandText = "UPDATE Items SET price=@pri WHERE flavour = 'Vanila'";
                cmd.Parameters.AddWithValue("@pri", txtVanila.Text);
               // cmd.Parameters.AddWithValue("@flavor", txtFlavour.Text.ToString());
                cmd.Connection = con;
                con.Open();

                cmd.ExecuteNonQuery();
                txtVanila.Text = String.Empty;

            }
        }
    }
}
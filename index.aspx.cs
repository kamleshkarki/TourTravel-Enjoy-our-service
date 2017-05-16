using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class newlook_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string str = @"Data Source=RamaKrishna;Initial Catalog=data;Integrated Security=True";
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        con.Open();
        cmd.CommandText = "Insert into Data(name,Email,phone,sub,messag) values(@name,@Email,@phone,@sub,@messag)";
        cmd.Connection = con;
        cmd.Parameters.AddWithValue("@name", Text1.Value);
        cmd.Parameters.AddWithValue("@Email", Text2.Value);
        cmd.Parameters.AddWithValue("@phone", Text3.Value);
        cmd.Parameters.AddWithValue("@sub", Text4.Value);
        cmd.Parameters.AddWithValue("@messag", TextBox1.Text);
        cmd.ExecuteNonQuery();
        con.Close();
        RegisterStartupScript("12", "<script>alert( ' data Inserted ')</script>");

    }

    protected void ModalButton_Click(object sender, EventArgs e)
    {
        string str = @"Data Source=RamaKrishna;Initial Catalog=data;Integrated Security=True";
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        con.Open();
        cmd.CommandText = "Insert into model(name,Email,Contact) values(@name,@Email,@Contact)";
        cmd.Connection = con;
        cmd.Parameters.AddWithValue("@name", Text5.Value);
        cmd.Parameters.AddWithValue("@Email", Text6.Value);
        cmd.Parameters.AddWithValue("@Contact", Text7.Value);
        cmd.ExecuteNonQuery();
        con.Close();
        RegisterStartupScript("12", "<script>alert( ' data Inserted ')</script>");

    }
}

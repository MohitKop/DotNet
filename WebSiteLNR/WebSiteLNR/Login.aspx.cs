using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Login : System.Web.UI.Page
{
   
    

    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void txtlogin_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\userdb.mdf;Integrated Security=True");
        con.Open();
        string check = "select * from emp_table where EmailID='" + Nametxt.Text + "'and Password='" + Passwordtxt.Text + "'";
        SqlCommand cm = new SqlCommand(check, con);
        int temp =Convert.ToInt32(cm.ExecuteScalar().ToString());
        con.Close();
        if (temp == 1)
        {
            Response.Redirect("Homepage.aspx");
        }
        else
        {
            Label1.Text = "Invalid Credentials";
        }

        /*SqlConnection scn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
        scn.Open();
        scn.ConnectionString = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\userdb.mdf;Integrated Security=True";
        SqlCommand scmd = new SqlCommand("select count (*) as cnt from emp_table where EmailID=@usr and POassword=@pwd", scn);
        scmd.Parameters.Clear();
        scmd.Parameters.AddWithValue("@usr", Nametxt.Text);
        scmd.Parameters.AddWithValue("@pwd", Passwordtxt.Text);
        

        if (scmd.ExecuteScalar().ToString() == "1")
        {
            Response.Redirect("welcome.aspx");
        }

        else
        {

            Label1.Text = "invalid credentials";
        }
        scn.Close();*/



    }
}
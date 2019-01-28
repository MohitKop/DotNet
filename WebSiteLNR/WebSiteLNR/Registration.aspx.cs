using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
public partial class Registration : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\userdb.mdf;Integrated Security=True");
    string gender;
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }

    /*protected void Button1_Click(object sender, EventArgs e)
    {
        Calendar1.Visible = true;
    }*/

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        dobtxt.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = false;

        int age = calage();
        Label1.Text = age.ToString();


    }


    protected void RegisterUser(object sender, EventArgs e)
    {
        /*SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\userdb.mdf;Integrated Security=True");
        con.Open();
        string check = "select * from emp_table where EmailID='" + Emailtxt.Text + "'";
        SqlCommand cm = new SqlCommand(check, con);
        int temp = Convert.ToInt32(cm.ExecuteScalar());
        con.Close();
        if (temp == 1)
        {
            Response.Write("user with same emailid already exist");
        }*/



        if (ddlist.SelectedItem.ToString() == "Male")
        { gender = "Male"; }
        else if (ddlist.SelectedItem.ToString() == "Female")
        { gender = "Female"; }


        int age = calage();
        //Label1.Text = age.ToString();

        string str = "insert into emp_table values('" + Fullnametxt.Text.Trim() + "','" + Emailtxt.Text.Trim() + "','" + dobtxt.Text.Trim() + "'," +
            "'" + biotxt.Text.Trim() + "','" + age + "','" + gender + "','" + passtxt.Text.Trim() + "')";

        con.Open();
        SqlCommand cmd = new SqlCommand(str, con);

        cmd.ExecuteNonQuery();
        con.Close();

        Response.Redirect("Login.aspx");
    }

    int calage()
    {
        DateTime f1 = DateTime.Parse(dobtxt.Text);
        DateTime f2 = DateTime.Now;
        TimeSpan ag = f2 - f1;
        double days = ag.TotalDays;
        int age = (int)days / 365;
        return age;
    }

    protected void cleartxt_Click(object sender, EventArgs e)
    {
        // Utilities.ResetAllControls(this);
        Fullnametxt.Text = string.Empty;
        Emailtxt.Text = string.Empty;
        dobtxt.Text = string.Empty;
        biotxt.Text = string.Empty;
        passtxt.Text = string.Empty;
        repasstxt.Text = string.Empty;
        ddlist.SelectedValue = "0";
        

    }


    protected void passtxt_TextChanged(object sender, EventArgs e)
    {

    }
}

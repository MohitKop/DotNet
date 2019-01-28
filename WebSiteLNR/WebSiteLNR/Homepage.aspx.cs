using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Homepage : System.Web.UI.Page
{
    string userId = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            lblServerDateTime.Text = DateTime.Now.ToString();
            userId =Request.QueryString["Id"];
            if(!string.IsNullOrEmpty(userId))
            {
                string userName = CheckUserName(userId);
                if(!string.IsNullOrEmpty(userName))
                {
                    lblUserId.Text = "Welcome " + userName;
                    lblUserId.Visible = true;


                }
                else { lblUserId.Visible = false;
                    userName = string.Empty;
                }
            }
        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        
    }

    private string CheckUserName(string userId)
    {
        string userName = string.Empty;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\userdb.mdf;Integrated Security=True");
        con.Open();
        string check = "select FullName from emp_table where ID='" + Convert.ToInt32(userId) +"'";
        SqlCommand cm = new SqlCommand(check, con);
        userName = Convert.ToString(cm.ExecuteScalar());
        con.Close();
        return userName;
    }

    protected void lblServerDateTime_TextChanged(object sender, EventArgs e)
    {

    }
}
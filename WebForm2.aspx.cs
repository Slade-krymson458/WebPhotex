using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebAppPhotEX
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string sqlString = @"Data Source=DESKTOP-F6MD9AO\SQLEXPRESS;Initial Catalog=UserRegistrationDB;Integrated Security=True";
    
   
        protected void Page_Load(object sender, EventArgs e)
        {
            LblMessage.Text = "If You Do Not Have An Account Please Click On Register";
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm1.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sqlString))
            {
                con.Open();
                string query = "SELECT COUNT(1) FROM UserRegistrationTable WHERE User_Name = @User_Name AND Password =@Password";

                SqlCommand sqlCom = new SqlCommand(query, con);

                sqlCom.Parameters.AddWithValue("@User_Name", TextBox1.Text.Trim());

                sqlCom.Parameters.AddWithValue("@Password", TextBox2.Text.Trim());

                
                int count = Convert.ToInt32(sqlCom.ExecuteScalar());

                if (count == 1)
                {
                    Session["User_Name"] = TextBox1.Text.Trim();
                    Response.Redirect("~/WebForm3.aspx");
                }
                else
                {
                    LblMessage.Text = "User/Password Incorrect Please Try again";
                }
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);

        }
    }
}
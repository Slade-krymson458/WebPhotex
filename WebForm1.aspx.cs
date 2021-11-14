using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace WebAppPhotEX
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       
       string sqlConnection = @"Data Source=DESKTOP-F6MD9AO\SQLEXPRESS;Initial Catalog=UserRegistrationDB;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Clear(); // When page is loaded fields will be cleared 
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm2.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           



            /*if (TextBox5.Text == "" || TextBox6.Text == "")
            {
                LblMessage.Text = "Error Registration  Not Successful Fill  User_Name or Password Fields !!!";
            
            }
            else*/
            if (TextBox6.Text !=TextBox7.Text)
            {
                LblMessage.Text = "Password Field Does not Match Confirm_Password Please make sure Fields are the same";
            }
            else if(TextBox1.Text == "" && TextBox2.Text =="" && TextBox3.Text ==""&& TextBox4.Text ==""&& TextBox5.Text =="")
            {
                LblMessage.Text = "Please Fill in all the fields";
            }
            else
            {


                SqlConnection sqlCon = new SqlConnection(sqlConnection);
                
                
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAddorEdit", sqlCon);

                    sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@ID_Number", Convert.ToInt32(hfID_Number.Value == "" ? "0" : hfID_Number.Value));

                    sqlCmd.Parameters.AddWithValue("@First_Name", TextBox2.Text.Trim());

                    sqlCmd.Parameters.AddWithValue("@Last_Name", TextBox3.Text.Trim());

                    sqlCmd.Parameters.AddWithValue("@Email_ID", TextBox4.Text.Trim());

                    sqlCmd.Parameters.AddWithValue("@User_Name", TextBox5.Text.Trim());

                    sqlCmd.Parameters.AddWithValue("@Password", TextBox6.Text.Trim());

                    sqlCmd.Parameters.AddWithValue("@Confirm_Password", TextBox7.Text.Trim());

                    sqlCmd.ExecuteNonQuery();

                    Clear();

                    LblMessage.Text = "Submitted Successfully ";

                      


            }


        }

         public void Clear() //Method/function used to clear all the entered values 
        {
            TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = TextBox5.Text = TextBox6.Text = TextBox7.Text = "";
            hfID_Number.Value = "";

        }

        

       
    }
}
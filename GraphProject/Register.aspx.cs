using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace Login_Form
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["graphConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblMessage.Text = "";
            //lblSuccessMsg.Text = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername2.Text != "" && txtPassword2.Text != "" && txtEmail.Text != "")
            {
                if (txtPassword2.Text.Length >= 6)
                {
                    SqlConnection con = null;
                    try
                    {
                        con = new SqlConnection(conn);
                        SqlCommand cmd = new SqlCommand("Select userid from logins where userid='" + txtUsername2.Text + "'", con);
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('Username exists..try different one')", true);
                        }
                        else
                        {
                            con.Close();
                            SqlCommand cmd2 = new SqlCommand("Insert into logins values(@rid,@userid,@pass,@email,@lvalid)", con);
                            cmd2.Parameters.AddWithValue("@rid", 2);
                            cmd2.Parameters.AddWithValue("@userid", txtUsername2.Text);
                            cmd2.Parameters.AddWithValue("@pass", txtPassword2.Text);
                            cmd2.Parameters.AddWithValue("@email", txtEmail.Text);
                            cmd2.Parameters.AddWithValue("@lvalid", 1);
                            con.Open();
                            cmd2.ExecuteNonQuery();

                            txtEmail.Text = txtPassword2.Text = txtUsername2.Text = "";
                            ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('User has been registered.')", true);
                        }
                        con.Close();
                    }
                    catch (Exception e3)
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('Error..Try Again')", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this,GetType(),"alert","alert('Password is required to have minimum length of 6')",true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('All fields are required')", true);
            }
        }
    }
}

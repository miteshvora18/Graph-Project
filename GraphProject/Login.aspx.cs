using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Login_Form
{
    public partial class Login : System.Web.UI.Page
    {
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["graphConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            if (!IsPostBack)
            {
                if (Request.QueryString["msg"] == "added")
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('Question has been added to test')", true);
                }
                if (Request.QueryString["msg"] == "logout")
                {
                    Session["user"] = null;
                    ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You are now logged out')", true);
                }
                if (Request.QueryString["msg"] == "expire")
                {
                    Session["user"] = null;
                    ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('Your session has expired..login again')", true);
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                if (txtUsername.Text != "" && txtPassword.Text != "")
                {
                    con = new SqlConnection(conn);
                    SqlCommand cmd = new SqlCommand("Select rname from logins l join roles r on r.rid=l.rid where userid=@userid and pass=@pass", con);
                    cmd.Parameters.AddWithValue("@userid", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            string role = dr[0].ToString();
                            con.Close();
                            Session["user"] = txtUsername.Text;
                            if (role == "admin")
                            {
                                Response.Redirect("AdminHome.aspx");
                            }
                            if (role == "user")
                            {
                                Response.Redirect("UserHome.aspx");
                            }
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('Invalid Username and/or Password')", true);
                    }
                    con.Close();
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('Username and Password are required')", true);
                }
            }
            catch (Exception e1)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('Error:"+e1+"')", true);
            }
        }
    }
}

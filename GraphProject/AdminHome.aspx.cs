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

namespace GraphProject
{
    public partial class AdminHome : System.Web.UI.Page
    {
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["graphConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["msg"] == "added")
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('Question has been added')", true);
                }
                SqlConnection con = null;
                try
                {
                    con = new SqlConnection(conn);
                    SqlCommand cmd = new SqlCommand("Select qid,qname,qlist from questions where qvalid=0", con);
                    //cmd.Parameters.AddWithValue("@valid", false);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    gvInvalidQuestions.DataSource = dr;
                    gvInvalidQuestions.DataBind();
                    con.Close();
                }
                catch (Exception e2)
                {
                    con.Close();
                    ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('Error..Try Again')", true);
                }
            }
        }

        protected void gvInvalidQuestions_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string qid = e.CommandArgument.ToString();
            Session["questionid"] = qid;
            Response.Redirect("SelectAns.aspx?qid="+qid);
        }
    }
}

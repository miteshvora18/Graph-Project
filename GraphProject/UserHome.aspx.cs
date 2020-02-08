﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace GraphProject
{
    public partial class UserHome : System.Web.UI.Page
    {
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["graphConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["msg"] == "invalid")
                {
                    ScriptManager.RegisterStartupScript(this,GetType(),"alert","alert('There was suspicious attempt to view unauthorized page..Start test again.')",true);
                }
                #region Get previous user results
                SqlConnection con = null;
                try
                {
                    con = new SqlConnection(conn);
                    SqlCommand cmd = new SqlCommand("Select totalQs,correctAns,percentage,testTime from testScore t join logins l on l.lid=t.lid where l.userid=@userid",con);
                    cmd.Parameters.AddWithValue("@userid",(string)Session["user"]);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    gvPreviousResults.DataSource = dr;
                    gvPreviousResults.DataBind();
                    con.Close();
                }
                catch (Exception e1)
                {
                    con.Close();
                }
                #endregion
            }
        }
        string[] randomQid = new string[5];
        int i = 0;
        protected void btnTest_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                Session["randomQid"+i] = "0";
                Session["answer" + i] = null;
            }
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand("SELECT TOP 5 qid FROM questions where qvalid=1 ORDER BY NEWID()",con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        randomQid[i]=dr[0].ToString();
                        i++;
                    }
                    if (randomQid[0] != null)
                        Session["randomQid1"] = randomQid[0].ToString();
                    else
                        Session["randomQid1"] = "0";
                    if (randomQid[1] != null)
                        Session["randomQid2"] = randomQid[1].ToString();
                    else
                        Session["randomQid2"] = "0";
                    if (randomQid[2] != null)
                        Session["randomQid3"] = randomQid[2].ToString();
                    else
                        Session["randomQid3"] = "0";
                    if (randomQid[3] != null)
                        Session["randomQid4"] = randomQid[3].ToString();
                    else
                        Session["randomQid4"] = "0";
                    if (randomQid[4] != null)
                        Session["randomQid5"] = randomQid[4].ToString();
                    else
                        Session["randomQid5"] = "0";
                    con.Close();
                    Response.Redirect("Test.aspx?Question=" + randomQid[0].ToString()+"&q=1");
                }
                else
                {
                    con.Close();
                    ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('There are no tests available now.')", true);
                }
            }
            catch (Exception e1)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('Error:Try Again.')", true);
            }
        }
    }
}

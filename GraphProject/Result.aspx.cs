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
using System.Collections.Generic;

namespace GraphProject
{
    public partial class Result : System.Web.UI.Page
    {
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["graphConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx?msg=expire");
            }
            if (!IsPostBack)
            {
                #region 1st Gridview 
                if (Session["answer1"] != null)
                {
                    lblQ1.Text = (string)Session["answer1"];
                }
                else
                    lblQ1.Text="No";

                if (Session["answer2"] != null)
                {
                    lblQ2.Text = (string)Session["answer2"];
                }
                else
                    lblQ2.Text = "No";

                if (Session["answer3"] != null)
                {
                    lblQ3.Text = (string)Session["answer3"];
                }
                else
                    lblQ3.Text = "No";

                if (Session["answer4"] != null)
                {
                    lblQ4.Text = (string)Session["answer4"];
                }
                else
                    lblQ4.Text = "No";

                if (Session["answer5"] != null)
                {
                    lblQ5.Text = (string)Session["answer5"];
                }
                else
                    lblQ5.Text = "No";
                #endregion

                #region Answer Gridview
                string[] testQid = new string[5];
                string[] incorrectAns = new string[5];
                for(int i=1;i<=5;i++)
                {
                    if((string)Session["randomQid"+i]!="0")
                    {
                        testQid[i - 1] = (string)Session["randomQid" + i];
                    }
                    if ((string)Session["answer" + i] == "No" || (string)Session["answer" + i] == null)
                    {
                        incorrectAns[i - 1] = (string)Session["randomQid" + i];
                    }
                    else
                    {
                        incorrectAns[i - 1] = "";
                    }
                }
                SqlConnection con = null;
                List<string> ids = new List<string>();
                try
                {
                    con = new SqlConnection(conn);
                    SqlCommand cmd = new SqlCommand("Select answer from questions where qid in(@ans1,@ans2,@ans3,@ans4,@ans5)", con);
                    cmd.Parameters.AddWithValue("@ans1", incorrectAns[0]);
                    cmd.Parameters.AddWithValue("@ans2", incorrectAns[1]);
                    cmd.Parameters.AddWithValue("@ans3", incorrectAns[2]);
                    cmd.Parameters.AddWithValue("@ans4", incorrectAns[3]);
                    cmd.Parameters.AddWithValue("@ans5", incorrectAns[4]);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ids.Add(dr[0].ToString());
                        }
                    }
                    #region show only incorrect questions
                    lblWQ1.Text = ids[0].Replace("img","");
                    lblWQ2.Text = ids[1].Replace("img", "");
                    lblWQ3.Text = ids[2].Replace("img", "");
                    lblWQ4.Text = ids[3].Replace("img", "");
                    lblWQ5.Text = ids[4].Replace("img", "");
                    int WrAnsCnt = ids.Count;
                    if (WrAnsCnt < 5)
                    {
                        q5.Visible = false;
                        if (WrAnsCnt < 4)
                        {
                            q4.Visible = false;
                            if (WrAnsCnt < 3)
                            {
                                q3.Visible = false;
                                if (WrAnsCnt < 2)
                                {
                                    q2.Visible = false;
                                    if (WrAnsCnt < 1)
                                    {
                                        q1.Visible = false;
                                        qh.Visible = false;
                                    }
                                }
                            }
                        }
                    }
                    #endregion
                    con.Close();
                }
                catch (Exception e1)
                {
                    con.Close();
                    ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('Error:"+e1.Message+"')", true);
                }
                #endregion

                #region Insert test score
                int correctAns=5-ids.Count;
                int percentage = (correctAns*100) / 5;
                string user=(string)Session["user"];
                string lid="";
                con = new SqlConnection(conn);
                SqlCommand cmdUser = new SqlCommand("Select lid from logins where userid=@userid",con);
                cmdUser.Parameters.AddWithValue("@userid",user);
                con.Open();
                SqlDataReader dr2 = cmdUser.ExecuteReader();
                if(dr2.HasRows)
                {
                    while (dr2.Read())
                    {
                        lid = dr2[0].ToString();
                    }
                }
                con.Close();

                con = new SqlConnection(conn);
                SqlCommand cmd2 = new SqlCommand("Insert into testScore values(@lid,@totalqs,@correctAns,@percentage,@testTime)",con);
                cmd2.Parameters.AddWithValue("@lid",lid);
                cmd2.Parameters.AddWithValue("totalQs",5);
                cmd2.Parameters.AddWithValue("@correctAns", correctAns);
                cmd2.Parameters.AddWithValue("@percentage", percentage);
                cmd2.Parameters.AddWithValue("@testTime",DateTime.Now);
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();
                #endregion
                lblPercent.Text = "Your percentage is:<span style='font-weight:bold;'>"+percentage+"</span>";

                #region BFS..DFS
                SqlCommand cmdbfs = new SqlCommand("Select top 1 fdesc from facts where fname='BFS' ORDER BY NEWID()",con);
                con.Open();
                SqlDataReader drbfs = cmdbfs.ExecuteReader();
                if (drbfs.HasRows)
                {
                    while (drbfs.Read())
                    {
                        lblBfs.Text = drbfs[0].ToString();
                    }
                }
                con.Close();

                SqlCommand cmddfs = new SqlCommand("Select top 1 fdesc from facts where fname='DFS' ORDER BY NEWID()", con);
                con.Open();
                SqlDataReader drdfs = cmddfs.ExecuteReader();
                if (drdfs.HasRows)
                {
                    while (drdfs.Read())
                    {
                        lblDfs.Text = drdfs[0].ToString();
                    }
                }
                con.Close();
                #endregion
            }
        }
    }
}

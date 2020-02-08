using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace GraphProject
{
    public partial class Test : System.Web.UI.Page
    {
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["graphConnection"].ConnectionString;
        public int qid
        {
            get
            {
                if (Request.QueryString["Question"] != null && Request.QueryString["Question"] != "")
                {
                    return Convert.ToInt32(Request.QueryString["Question"]);
                }
                else
                {
                    return 0;
                }
            }
        }
        public int q
        {
            get
            {
                if (Request.QueryString["q"] != null)
                {
                    return Convert.ToInt32(Request.QueryString["q"]);
                }
                else
                {
                    return 0;
                }
            }
        }
        public List<string> selImg
        {
            get
            {
                if (HttpContext.Current.Session["selImg"] == null)
                {
                    HttpContext.Current.Session["selImg"] = new List<string>();
                }
                return HttpContext.Current.Session["selImg"] as List<string>;
            }
            set
            {
                HttpContext.Current.Session["selImg"] = value;
            }

        }
        public string[] s
        {
            get
            {
                if (HttpContext.Current.Session["s"] == null)
                {
                    HttpContext.Current.Session["s"] = new string[60];
                }
                return HttpContext.Current.Session["s"] as string[];
            }
            set
            {
                HttpContext.Current.Session["s"] = value;
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (q == 5)
            {
                btnNext.Visible = false;
            }
            if (qid == 0)
            {
                Response.Redirect("~/UserHome.aspx?msg=invalid");
            }

            if (!IsPostBack)
            {
                #region Remove unwanted questions
                selImg = null;
                SqlConnection con = null;
                string[] sFinal;
                try
                {
                    string[] allQs={"A1","A2","A3","A4","A11","A12","A21","A22","A31","A32","A41","A42","A111","A112","A121","A122","A211","A212","A221","A222","A311","A312","A321","A322","A411","A412","A421","A422"};
                    con = new SqlConnection(conn);
                    SqlCommand cmd = new SqlCommand("Select qlist,qname from questions where qid="+qid,con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            string selQs = dr[0].ToString();
                            s = selQs.Split(',');
                            string[] sSel = new string[s.Length];
                            for (int i = 1; i <= s.Length; i++)
                            {
                                sSel[i - 1] = s[i - 1].Remove(0, 3);
                            }
                            sFinal = allQs.Except(sSel).ToArray();
                            //Control c = FindControl("img" + sFinal[0]);
                            //c.Visible = false;
                            List<Control> ids = new List<Control>();
                            for (int i = 0; i < sFinal.Count(); i++)
                            {
                                ids.Add(FindControl("img" + sFinal[i]));
                                ids.Add(FindControl("ln" + sFinal[i]));
                            }
                            for (int i = 0; i < ids.Count; i++)
                            {
                                ids[i].Visible = false;
                            }
                            lblQName.Text = dr[1].ToString();
                        }
                    }
                    else
                    {
                        Response.Redirect("~/UserHome.aspx?msg=invalid");
                    }
                    con.Close();
                }
                catch (Exception e1)
                {
                    con.Close();
                    ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('Error..Try Again')", true);
                }
                #endregion
            }
        }

        #region Image Click Functions
        protected void imgA_Click(object sender, ImageClickEventArgs e)
        {
            selImg.Add("imgA");
            imgA.ImageUrl = "~/ClickImages/AR.jpg";
            imgA.Enabled = false;
        }
        protected void imgA1_Click(object sender, ImageClickEventArgs e)
        {
            selImg.Add("imgA1");
            imgA1.ImageUrl = "~/ClickImages/A1R.jpg";
            imgA1.Enabled = false;
        }
        protected void imgA2_Click(object sender, ImageClickEventArgs e)
        {
            selImg.Add("imgA2");
            imgA2.ImageUrl = "~/ClickImages/A2R.jpg";
            imgA2.Enabled = false;
        }
        protected void imgA3_Click(object sender, ImageClickEventArgs e)
        {
            selImg.Add("imgA3");
            imgA3.ImageUrl = "~/ClickImages/A3R.jpg";
            imgA3.Enabled = false;
        }
        protected void imgA4_Click(object sender, ImageClickEventArgs e)
        {
            selImg.Add("imgA4");
            imgA4.ImageUrl = "~/ClickImages/A4R.jpg";
            imgA4.Enabled = false;
        }
        protected void imgA11_Click(object sender, ImageClickEventArgs e)
        {
            
                selImg.Add("imgA11");
                imgA11.ImageUrl = "~/ClickImages/A11R.jpg";
                imgA11.Enabled = false;
            
        }
        protected void imgA12_Click(object sender, ImageClickEventArgs e)
        {
            
                selImg.Add("imgA11");
                imgA12.Enabled = false;
                imgA12.ImageUrl = "~/ClickImages/A12R.jpg";
           
        }
        protected void imgA21_Click(object sender, ImageClickEventArgs e)
        {
           
                selImg.Add("imgA21");
                imgA21.Enabled = false;
                imgA21.ImageUrl = "~/ClickImages/A21R.jpg";
            
        }
        protected void imgA22_Click(object sender, ImageClickEventArgs e)
        {
                selImg.Add("imgA22");
                imgA22.Enabled = false;
                imgA22.ImageUrl = "~/ClickImages/A22R.jpg";
            
        }
        protected void imgA31_Click(object sender, ImageClickEventArgs e)
        {
            
                selImg.Add("imgA31");
                imgA31.Enabled = false;
                imgA31.ImageUrl = "~/ClickImages/A31R.jpg";
            
        }
        protected void imgA32_Click(object sender, ImageClickEventArgs e)
        {
           
                selImg.Add("imgA32");
                imgA32.Enabled = false;
                imgA32.ImageUrl = "~/ClickImages/A32R.jpg";
            
            
        }
        protected void imgA41_Click(object sender, ImageClickEventArgs e)
        {
                selImg.Add("imgA41");
                imgA41.Enabled = false;
                imgA41.ImageUrl = "~/ClickImages/A41R.jpg";
           
        }
        protected void imgA42_Click(object sender, ImageClickEventArgs e)
        {
            
                selImg.Add("imgA42");
                imgA42.Enabled = false;
                imgA42.ImageUrl = "~/ClickImages/A42R.jpg";
            
        }
        protected void imgA111_Click(object sender, ImageClickEventArgs e)
        {
            
                selImg.Add("imgA111");
                imgA111.Enabled = false;
                imgA111.ImageUrl = "~/ClickImages/A111R.jpg";
            
        }
        protected void imgA112_Click(object sender, ImageClickEventArgs e)
        {
            
                selImg.Add("imgA112");
                imgA112.Enabled = false;
                imgA112.ImageUrl = "~/ClickImages/A112R.jpg";
            
        }
        protected void imgA121_Click(object sender, ImageClickEventArgs e)
        {
            
                selImg.Add("imgA121");
                imgA121.Enabled = false;
                imgA121.ImageUrl = "~/ClickImages/A121R.jpg";
            
        }
        protected void imgA122_Click(object sender, ImageClickEventArgs e)
        {
            
                selImg.Add("imgA122");
                imgA122.Enabled = false;
                imgA122.ImageUrl = "~/ClickImages/A122R.jpg";
            
        }
        protected void imgA211_Click(object sender, ImageClickEventArgs e)
        {
            
                selImg.Add("imgA211");
                imgA211.Enabled = false;
                imgA211.ImageUrl = "~/ClickImages/A211R.jpg";
            
        }
        protected void imgA212_Click(object sender, ImageClickEventArgs e)
        {
            
                selImg.Add("imgA212");
                imgA212.Enabled = false;
                imgA212.ImageUrl = "~/ClickImages/A212R.jpg";
           
        }
        protected void imgA221_Click(object sender, ImageClickEventArgs e)
        {
                selImg.Add("imgA221");
                imgA221.Enabled = false;
                imgA221.ImageUrl = "~/ClickImages/A221R.jpg";
            
        }
        protected void imgA222_Click(object sender, ImageClickEventArgs e)
        {
            
                selImg.Add("imgA222");
                imgA222.Enabled = false;
                imgA222.ImageUrl = "~/ClickImages/A222R.jpg";
            
        }
        protected void imgA311_Click(object sender, ImageClickEventArgs e)
        {
            
                selImg.Add("imgA311");
                imgA311.Enabled = false;
                imgA311.ImageUrl = "~/ClickImages/A311R.jpg";
            
        }
        protected void imgA312_Click(object sender, ImageClickEventArgs e)
        {
            
                selImg.Add("imgA312");
                imgA312.Enabled = false;
                imgA312.ImageUrl = "~/ClickImages/A312R.jpg";
            
        }
        protected void imgA321_Click(object sender, ImageClickEventArgs e)
        {
            
                selImg.Add("imgA321");
                imgA321.Enabled = false;
                imgA321.ImageUrl = "~/ClickImages/A321R.jpg";
           
        }
        protected void imgA322_Click(object sender, ImageClickEventArgs e)
        {
            
                selImg.Add("imgA322");
                imgA322.Enabled = false;
                imgA322.ImageUrl = "~/ClickImages/A322R.jpg";
            
        }
        protected void imgA411_Click(object sender, ImageClickEventArgs e)
        {
            
                selImg.Add("imgA411");
                imgA411.Enabled = false;
                imgA411.ImageUrl = "~/ClickImages/A411R.jpg";
            
        }
        protected void imgA412_Click(object sender, ImageClickEventArgs e)
        {
           
                selImg.Add("imgA412");
                imgA412.Enabled = false;
                imgA412.ImageUrl = "~/ClickImages/A412R.jpg";
            
        }
        protected void imgA421_Click(object sender, ImageClickEventArgs e)
        {
            
                selImg.Add("imgA421");
                imgA421.Enabled = false;
                imgA421.ImageUrl = "~/ClickImages/A421R.jpg";
           
        }
        protected void imgA422_Click(object sender, ImageClickEventArgs e)
        {
           
                selImg.Add("imgA422");
                imgA422.Enabled = false;
                imgA422.ImageUrl = "~/ClickImages/A422R.jpg";
           
        }
    #endregion
        
        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                string singleItem = "";
                string dbAnswer = "";
                int cnt = selImg.Count;

                if (s.Length == cnt - 1)
                {
                    for (int i = 1; i <= cnt; i++)
                    {
                        if (i != cnt)
                        {
                            singleItem += selImg[i - 1] + ",";
                        }
                        else
                        {
                            singleItem += selImg[i - 1];
                        }
                    }
                    con = new SqlConnection(conn);
                    SqlCommand cmd = new SqlCommand("Select answer from questions where qid=@qid", con);
                    cmd.Parameters.AddWithValue("@qid", qid);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            dbAnswer = dr[0].ToString();
                        }
                    }
                    con.Close();
                    if (dbAnswer == singleItem)
                    {
                        Session["answer" + q] = "Yes";
                    }
                    else
                    {
                        Session["answer" + q]="No";
                    }
                    int next = q + 1;
                    selImg = null;
                    s = null;
                    string nextQs = (string)Session["randomQid" + next];
                    if (nextQs != null)
                    {
                        Response.Redirect("Test.aspx?Question=" + nextQs + "&q=" + next);
                    }
                    else
                    {
                        Response.Redirect("UserHome.aspx?msg=invalid");
                    }
                    Clear();
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select all elements before submit.')", true);
                    Clear();
                    selImg = null;
                    s = null;
                }
            }
            catch (Exception e1)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('Error saving answer..try again.')", true);
                con.Close();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Result.aspx");
        }

        public void Clear()
        {
            selImg = null;

            imgA.ImageUrl = "~/Image/A.jpg";
            imgA.Enabled = true;
            imgA1.ImageUrl = "~/Image/A1.jpg";
            imgA1.Enabled = true;
            imgA2.ImageUrl = "~/Image/A2.jpg";
            imgA2.Enabled = true;
            imgA3.ImageUrl = "~/Image/A3.jpg";
            imgA3.Enabled = true;
            imgA4.ImageUrl = "~/Image/A4.jpg";
            imgA4.Enabled = true;

            imgA11.ImageUrl = "~/Image/A11.jpg";
            imgA11.Enabled = true;
            imgA12.ImageUrl = "~/Image/A12.jpg";
            imgA12.Enabled = true;
            imgA21.ImageUrl = "~/Image/A21.jpg";
            imgA21.Enabled = true;
            imgA22.ImageUrl = "~/Image/A22.jpg";
            imgA22.Enabled = true;
            imgA31.ImageUrl = "~/Image/A31.jpg";
            imgA31.Enabled = true;
            imgA32.ImageUrl = "~/Image/A32.jpg";
            imgA32.Enabled = true;
            imgA41.ImageUrl = "~/Image/A41.jpg";
            imgA41.Enabled = true;
            imgA42.ImageUrl = "~/Image/A42.jpg";
            imgA42.Enabled = true;

            imgA111.ImageUrl = "~/Image/A111.jpg";
            imgA111.Enabled = true;
            imgA112.ImageUrl = "~/Image/A112.jpg";
            imgA112.Enabled = true;
            imgA121.ImageUrl = "~/Image/A121.jpg";
            imgA121.Enabled = true;
            imgA122.ImageUrl = "~/Image/A122.jpg";
            imgA122.Enabled = true;
            imgA211.ImageUrl = "~/Image/A211.jpg";
            imgA211.Enabled = true;
            imgA212.ImageUrl = "~/Image/A212.jpg";
            imgA212.Enabled = true;
            imgA221.ImageUrl = "~/Image/A221.jpg";
            imgA221.Enabled = true;
            imgA222.ImageUrl = "~/Image/A222.jpg";
            imgA222.Enabled = true;

            imgA311.ImageUrl = "~/Image/A311.jpg";
            imgA311.Enabled = true;
            imgA312.ImageUrl = "~/Image/A312.jpg";
            imgA312.Enabled = true;
            imgA321.ImageUrl = "~/Image/A321.jpg";
            imgA321.Enabled = true;
            imgA322.ImageUrl = "~/Image/A322.jpg";
            imgA322.Enabled = true;
            imgA411.ImageUrl = "~/Image/A411.jpg";
            imgA411.Enabled = true;
            imgA412.ImageUrl = "~/Image/A412.jpg";
            imgA412.Enabled = true;
            imgA421.ImageUrl = "~/Image/A421.jpg";
            imgA421.Enabled = true;
            imgA422.ImageUrl = "~/Image/A422.jpg";
            imgA422.Enabled = true;
        }
    }
}

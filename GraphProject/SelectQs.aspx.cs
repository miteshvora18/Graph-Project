using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace GraphProject
{
    public partial class Default2 : System.Web.UI.Page
    {
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["graphConnection"].ConnectionString;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                selImg = null;
            }
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
            if (imgA1.ImageUrl == "~/ClickImages/A1R.jpg")
            {
                selImg.Add("imgA11");
                imgA11.ImageUrl = "~/ClickImages/A11R.jpg";
                imgA11.Enabled = false;
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A1 before selecting A11')", true);
            }
        }
        protected void imgA12_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA1.ImageUrl == "~/ClickImages/A1R.jpg")
            {
                selImg.Add("imgA12");
                imgA12.Enabled = false;
                imgA12.ImageUrl = "~/ClickImages/A12R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A1 before selecting A12')", true);
            }
        }
        protected void imgA21_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA2.ImageUrl == "~/ClickImages/A2R.jpg")
            {
                selImg.Add("imgA21");
                imgA21.Enabled = false;
                imgA21.ImageUrl = "~/ClickImages/A21R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A2 before selecting A21')", true);
            }
        }
        protected void imgA22_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA2.ImageUrl == "~/ClickImages/A2R.jpg")
            {
                selImg.Add("imgA22");
                imgA22.Enabled = false;
                imgA22.ImageUrl = "~/ClickImages/A22R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A2 before selecting A22')", true);
            }
        }
        protected void imgA31_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA3.ImageUrl == "~/ClickImages/A3R.jpg")
            {
                selImg.Add("imgA31");
                imgA31.Enabled = false;
                imgA31.ImageUrl = "~/ClickImages/A31R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A3 before selecting A31')", true);
            }
        }
        protected void imgA32_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA3.ImageUrl == "~/ClickImages/A3R.jpg")
            {
                selImg.Add("imgA32");
                imgA32.Enabled = false;
                imgA32.ImageUrl = "~/ClickImages/A32R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A3 before selecting A32')", true);
            }
        }
        protected void imgA41_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA4.ImageUrl == "~/ClickImages/A4R.jpg")
            {
                selImg.Add("imgA41");
                imgA41.Enabled = false;
                imgA41.ImageUrl = "~/ClickImages/A41R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A4 before selecting A41')", true);
            }
        }
        protected void imgA42_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA4.ImageUrl == "~/ClickImages/A4R.jpg")
            {
                selImg.Add("imgA42");
                imgA42.Enabled = false;
                imgA42.ImageUrl = "~/ClickImages/A42R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A4 before selecting A42')", true);
            }
        }
        protected void imgA111_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA1.ImageUrl == "~/ClickImages/A1R.jpg" && imgA11.ImageUrl == "~/ClickImages/A11R.jpg")
            {
                selImg.Add("imgA111");
                imgA111.Enabled = false;
                imgA111.ImageUrl = "~/ClickImages/A111R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A1 and A11 before selecting A111')", true);
            }
        }
        protected void imgA112_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA1.ImageUrl == "~/ClickImages/A1R.jpg" && imgA11.ImageUrl == "~/ClickImages/A11R.jpg")
            {
                selImg.Add("imgA112");
                imgA112.Enabled = false;
                imgA112.ImageUrl = "~/ClickImages/A112R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A1 and A11 before selecting A112')", true);
            }
        }
        protected void imgA121_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA1.ImageUrl == "~/ClickImages/A1R.jpg" && imgA12.ImageUrl == "~/ClickImages/A12R.jpg")
            {
                selImg.Add("imgA121");
                imgA121.Enabled = false;
                imgA121.ImageUrl = "~/ClickImages/A121R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A1 and A12 before selecting A121')", true);
            }
        }
        protected void imgA122_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA1.ImageUrl == "~/ClickImages/A1R.jpg" && imgA12.ImageUrl == "~/ClickImages/A12R.jpg")
            {
                selImg.Add("imgA122");
                imgA122.Enabled = false;
                imgA122.ImageUrl = "~/ClickImages/A122R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A1 and A12 before selecting A122')", true);
            }
        }
        protected void imgA211_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA1.ImageUrl == "~/ClickImages/A1R.jpg" && imgA21.ImageUrl == "~/ClickImages/A21R.jpg")
            {
                selImg.Add("imgA211");
                imgA211.Enabled = false;
                imgA211.ImageUrl = "~/ClickImages/A211R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A1 and A21 before selecting A211')", true);
            }
        }
        protected void imgA212_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA1.ImageUrl == "~/ClickImages/A1R.jpg" && imgA21.ImageUrl == "~/ClickImages/A21R.jpg")
            {
                selImg.Add("imgA212");
                imgA212.Enabled = false;
                imgA212.ImageUrl = "~/ClickImages/A212R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A1 and A21 before selecting A212')", true);
            }
        }
        protected void imgA221_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA1.ImageUrl == "~/ClickImages/A1R.jpg" && imgA22.ImageUrl == "~/ClickImages/A22R.jpg")
            {
                selImg.Add("imgA221");
                imgA221.Enabled = false;
                imgA221.ImageUrl = "~/ClickImages/A221R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A1 and A22 before selecting A221')", true);
            }
        }
        protected void imgA222_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA1.ImageUrl == "~/ClickImages/A1R.jpg" && imgA22.ImageUrl == "~/ClickImages/A22R.jpg")
            {
                selImg.Add("imgA222");
                imgA222.Enabled = false;
                imgA222.ImageUrl = "~/ClickImages/A222R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A1 and A22 before selecting A222')", true);
            }
        }
        protected void imgA311_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA1.ImageUrl == "~/ClickImages/A1R.jpg" && imgA31.ImageUrl == "~/ClickImages/A31R.jpg")
            {
                selImg.Add("imgA311");
                imgA311.Enabled = false;
                imgA311.ImageUrl = "~/ClickImages/A311R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A1 and A31 before selecting A311')", true);
            }
        }
        protected void imgA312_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA1.ImageUrl == "~/ClickImages/A1R.jpg" && imgA31.ImageUrl == "~/ClickImages/A31R.jpg")
            {
                selImg.Add("imgA312");
                imgA312.Enabled = false;
                imgA312.ImageUrl = "~/ClickImages/A312R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A1 and A31 before selecting A312')", true);
            }
        }
        protected void imgA321_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA1.ImageUrl == "~/ClickImages/A1R.jpg" && imgA32.ImageUrl == "~/ClickImages/A32R.jpg")
            {
                selImg.Add("imgA321");
                imgA321.Enabled = false;
                imgA321.ImageUrl = "~/ClickImages/A321R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A1 and A32 before selecting A321')", true);
            }
        }
        protected void imgA322_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA1.ImageUrl == "~/ClickImages/A1R.jpg" && imgA32.ImageUrl == "~/ClickImages/A32R.jpg")
            {
                selImg.Add("imgA322");
                imgA322.Enabled = false;
                imgA322.ImageUrl = "~/ClickImages/A322R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A1 and A32 before selecting A322')", true);
            }
        }
        protected void imgA411_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA1.ImageUrl == "~/ClickImages/A1R.jpg" && imgA41.ImageUrl == "~/ClickImages/A41R.jpg")
            {
                selImg.Add("imgA411");
                imgA411.Enabled = false;
                imgA411.ImageUrl = "~/ClickImages/A411R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A1 and A41 before selecting A411')", true);
            }
        }
        protected void imgA412_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA1.ImageUrl == "~/ClickImages/A1R.jpg" && imgA41.ImageUrl == "~/ClickImages/A41R.jpg")
            {
                selImg.Add("imgA412");
                imgA412.Enabled = false;
                imgA412.ImageUrl = "~/ClickImages/A412R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A1 and A41 before selecting A412')", true);
            }
        }
        protected void imgA421_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA1.ImageUrl == "~/ClickImages/A1R.jpg" && imgA42.ImageUrl == "~/ClickImages/A42R.jpg")
            {
                selImg.Add("imgA421");
                imgA421.Enabled = false;
                imgA421.ImageUrl = "~/ClickImages/A421R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A1 and A42 before selecting A421')", true);
            }
        }
        protected void imgA422_Click(object sender, ImageClickEventArgs e)
        {
            if (imgA1.ImageUrl == "~/ClickImages/A1R.jpg" && imgA42.ImageUrl == "~/ClickImages/A42R.jpg")
            {
                selImg.Add("imgA422");
                imgA422.Enabled = false;
                imgA422.ImageUrl = "~/ClickImages/A422R.jpg";
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select A1 and A42 before selecting A422')", true);
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHome.aspx");
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            SqlConnection con=null;
            try
            {
                string singleItem = "";
                int cnt=selImg.Count;

                if (cnt != 0)
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
                    SqlCommand cmd = new SqlCommand("Insert into questions values(@qname,@qdesc,@qcreated,@qlist,@answer,@qvalid)", con);
                    cmd.Parameters.AddWithValue("@qname", "");
                    cmd.Parameters.AddWithValue("@qdesc", "");
                    cmd.Parameters.AddWithValue("@qcreated", 1);
                    cmd.Parameters.AddWithValue("@qlist", singleItem);
                    cmd.Parameters.AddWithValue("@answer", "");
                    cmd.Parameters.AddWithValue("@qvalid", false);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Clear();
                    selImg = null;
                    SqlCommand cmd2 = new SqlCommand("select top 1 qid from questions order by qid desc", con);
                    con.Open();
                    SqlDataReader dr = cmd2.ExecuteReader();
                    while (dr.Read())
                    {
                        string qid = dr[0].ToString();
                        con.Close();
                        Response.Redirect("SelectAns.aspx?qid=" + qid);
                    }
                }
                else
                {
                    Clear();
                    selImg = null;
                    ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('You must select atleast one question other than A.')", true);
                }
            }
            catch (Exception e1)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('Error saving question..try again.')", true);
                con.Close();
            }
            
        }

        public void Clear()
        {
            selImg = null;

            imgA.ImageUrl = "~/ClickImages/AR.jpg";
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

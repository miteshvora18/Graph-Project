using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GraphProject
{
    public partial class User : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                lblUser.Text = "Welcome, " + (string)Session["user"];
            }
            else
            {
                Response.Redirect("Login.aspx?msg=expire");
            }
        }
    }
}

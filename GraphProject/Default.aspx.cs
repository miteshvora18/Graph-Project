using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GraphProject
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnA1_Click(object sender, EventArgs e)
        {
            if (btnA1.CssClass != "btnGraphSelected")
                btnA1.CssClass = "btnGraphSelected";
            else
            {
                btnA1.CssClass.Replace("btnGraphSelected","");
                btnA11.CssClass.Replace("btnGraphSelected", "");
            }
        }
    }
}

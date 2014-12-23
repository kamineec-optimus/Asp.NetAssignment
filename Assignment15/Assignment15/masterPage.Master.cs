using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment15
{
    public partial class masterPage : System.Web.UI.MasterPage
    {
        private const string msg = "WelCome {0}";
        protected void Page_Load(object sender, EventArgs e)
        {
            
                //lblmsg.Text = String.Format(msg, Session["UserName"]);
            
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryProject
{
    public partial class Home : System.Web.UI.Page
    {
        /// <summary>
        /// Variable to save previous page URL
        /// </summary>
        static string PrePage = string.Empty;

        /// <summary>
        /// Variable to print message;
        /// </summary>
        public const string msg = "Hello {0}";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PrePage = Request.UrlReferrer.ToString();
            }
            lblMsg.Text = string.Format(msg, Session["UserName"]);
        }

        /// <summary>
        /// method to go back to the previous page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnPrevious_Click(object sender, EventArgs e)
        {
            Response.Redirect(PrePage);
        }

        /// <summary>
        /// method to logout User
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
    }
}
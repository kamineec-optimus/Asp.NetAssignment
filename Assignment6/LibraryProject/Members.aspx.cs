using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using BusinessLayer.Model;

namespace LibraryProject
{
    public partial class Members : System.Web.UI.Page
    {
        /// <summary>
        /// Create Object of Member Class 
        /// </summary>
        Member objMember = new Member();

        /// <summary>
        /// Variable to save previous page URL
        /// </summary>
        static string PrePage = string.Empty;

        /// <summary>
        /// Variable to print msg;
        /// </summary>
        public const string msg = "Hello {0}";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserType"].ToString() == "Admin")
                {
                    multiView.ActiveViewIndex = 0;
                }
                PrePage = Request.UrlReferrer.ToString();
            }
            lblMsg.Text = string.Format(msg, Session["UserName"]);
            BindGrid();            
        }

        /// <summary>
        /// Bind GridView to Members
        /// </summary>
        public void BindGrid()
        {        
            gvMembers.DataSource = objMember.LoadMembers();
            gvMembers.DataBind();
        }

        /// <summary>
        /// Method to add members
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAddMember_Click(object sender, EventArgs e)
        {
            objMember.AddMember(txtMemberName.Text, txtAddress.Text, int.Parse(txtRoleId.Text), txtUserName.Text, txtPassword.Text);
            BindGrid();
            txtAddress.Text = "";
            txtMemberName.Text = "";
            txtPassword.Text = "";
            txtRoleId.Text = "";
            txtUserName.Text = "";

        }
        /// <summary>
        /// Method to go back to the previous page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnPrevious_Click(object sender, EventArgs e)
        {
            Response.Redirect(PrePage);
        }

        /// <summary>
        /// Method to logout the user
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
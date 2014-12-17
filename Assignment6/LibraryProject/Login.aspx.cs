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
    public partial class Login : System.Web.UI.Page
    {
        UserLogin objBLogin = new UserLogin();
        public const string msg = "Your UserName/Password is incorrect";

        protected void btnLogin_Click(object sender, EventArgs e)
        {
          ///Save the values in session

            Session["UserType"] = objBLogin.GetUserType(txtUserName.Text, txtPassword.Text);
            Session["UserId"] = objBLogin.GetUserId(txtUserName.Text, txtPassword.Text);
            Session["UserName"] = txtUserName.Text;


            if (objBLogin.Login(txtUserName.Text, txtPassword.Text) == true)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblmsg.Text = msg;
                txtUserName.Text = string.Empty;
                txtPassword.Text = string.Empty;                
            }
           

        }
    }
}
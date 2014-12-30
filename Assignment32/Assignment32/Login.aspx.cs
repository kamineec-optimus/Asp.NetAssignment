using System;

namespace Assignment32
{
    public partial class Login : System.Web.UI.Page
    {
        private const string roleID = "Home.aspx?RoleID={0}";
        private const string msg = "UserName/Password is incorrect";
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
           //object of userDetail Class
            UserDetail obj = new UserDetail();

            int roleId = obj.UserLogin(txtUserName.Text, txtPassword.Text);
            //match the username and password
            if (roleId>0)
            {
                Response.Redirect(string.Format(roleID, roleId));
            }
            else
            {
                lblMsg.Text = msg;
            }
        }

       
    }
}
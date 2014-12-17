using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4
{
    public partial class TestString : System.Web.UI.Page
    {
        string str = "Hello World";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Label1.Text = str;
        }

        protected void btnClone_Click(object sender, EventArgs e)
        {
            string str1 = string.Empty;
            str1 = str.Clone().ToString();
            Label1.Text = str1;
        }

        protected void btnCompareTo_Click(object sender, EventArgs e)
        {
          Label1.Text = Convert.ToInt32(str.CompareTo(TextBox1.Text).ToString()) == 1? "Not Equal" : "Equal";
            
        }

        protected void btnContains_Click(object sender, EventArgs e)
        {
            
            Label1.Text = (Convert.ToInt32(str.Contains(TextBox1.Text))) == 1 ? "Yes" : "No";
        }

        protected void btnIndexOf_Click(object sender, EventArgs e)
        {
            Label2.Text = "Find first index of any charecter in " + str;
            Label2.Text = str.IndexOf(TextBox1.Text).ToString();

        }

        protected void btnToLower_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text.ToLower();
        }

        protected void btnToUpper_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text.ToUpper();

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Label1.Text = str.Insert(0, TextBox1.Text);
        }

        protected void btnLength_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text.Length.ToString();
        }

        protected void btnLastIndexOF_Click(object sender, EventArgs e)
        {
            Label1.Text = str.LastIndexOf(TextBox1.Text).ToString();
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            Label1.Text = str.Remove(Convert.ToInt32(TextBox1.Text));
        }

        protected void btnReplace_Click(object sender, EventArgs e)
        {
            Label1.Text = str.Replace("l", TextBox1.Text);

        }

    }
}
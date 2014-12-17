using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ques1
{
    public partial class TestIf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (rbtnC.Checked)
            {
                lbl.Text = "Good choice, C# is a fine language.";
            }
            else if (rbtnVB.Checked)
            {
                lbl.Text = "VB .NET: OOP, multithreading and more!";
            }
            else if (rbtnOther.Checked)
            {
                lbl.Text = "Well...good luck with that!";
            }
        }  
       
     }
 
}
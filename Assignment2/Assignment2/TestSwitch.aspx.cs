using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2
{
    public partial class TestSwitch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = 0;
            if (rbtnC.Checked)
            {
                i = 1;
            }
            else if(rbtnVB.Checked)
            {
                i = 2;
            }
            else if (rbtnOther.Checked)
            {
                i = 3;
            }
            switch (i)
            {
                case 1:
                    lbl.Text= "Good choice, C# is a fine language.";
                    break;
                case 2:
                    lbl.Text ="VB .NET: OOP, multithreading and more!";
                    break;
                case 3:
                    lbl.Text = "Well...good luck with that!";
                    break;

            }
        }
    }
}
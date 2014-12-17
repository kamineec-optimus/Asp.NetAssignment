using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5
{
    public partial class PrintArray : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] arr1 = ReturnArray.GetStringArray();
            for (int i = 0; i < arr1.Length; i++)
            {
                Label1.Text += arr1[i]+ " ";

            }
                    
        }

        
    }
    public class ReturnArray
    {
        public static string[] GetStringArray()
        {
            string[] arr = new string[] { "Sun", "Mon", "Tues", "Wed", "Thr", "Fri", "Sat" };
            return arr;
        }
    }
}
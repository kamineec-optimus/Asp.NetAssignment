using System;

namespace SampleWebApp
{
    public partial class Home : System.Web.UI.Page
    {      

        protected void btnCalculateMarks_Click(object sender, EventArgs e)
        {
            
            Marks marks = new Marks();
            // Show the total marks on label based on the percentage provided by User
            lblMarks.Text = marks.CalculateMarks(double.Parse(txtPercentage.Text)).ToString();
        }
    }
}
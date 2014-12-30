using System;
using System.Xml;

namespace Assignment25
{
    public partial class Student : System.Web.UI.Page
    {
        /// <summary>
        /// object of xmloperation class
        /// </summary>
        XmlOperation objXmlOperation = new XmlOperation();
       
        protected void btnPrintStudent_Click(object sender, EventArgs e)
        {
            ///print the name of student having mca branch
            lblName.Text = objXmlOperation.GetMCAStudent();
          
        }

        protected void btnGradeD_Click(object sender, EventArgs e)
        {
            ///print the name of student having grade d
            lblGrade.Text = objXmlOperation.GetStudentWithDGrade();
        }
    }
}
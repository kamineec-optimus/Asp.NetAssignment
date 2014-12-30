using System;
using System.Collections.Generic;

namespace Assignment29
{
    public partial class Home : System.Web.UI.Page
    {
        /// <summary>
        /// private string to store address
        /// </summary>
        private const string Address = "{0},{1}";
        /// <summary>
        /// object of Student class
        /// </summary>
        Students obj = new Students();
        protected void Page_Load(object sender, EventArgs e)
        {
               //list of students       
            List<Students> listStudent;
            listStudent = obj.GetStudent();
            //display the name, age and address of the student
            foreach (var item in listStudent)
            {
                txtName.Text = item.StudentName;
                txtAge.Text = item.StudentAge.ToString();
                txtAddress.Text = string.Format(Address, item.Country, item.City);
            }
            
        }

        protected void btnAddNode_Click(object sender, EventArgs e)
        {
            //call student class's method to append a child node
            obj.AppendChild();
        }
    }
}
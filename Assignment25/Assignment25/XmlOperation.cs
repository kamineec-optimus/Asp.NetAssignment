using System;
using System.Web;
using System.Xml;

namespace Assignment25
{
    public class XmlOperation
    {
        /// <summary>
        /// get students with branch as MCA
        /// </summary>
        private const string MCAStudents ="/Studentlist/Student[@branch='MCA']";
        /// <summary>
        /// Students having grade D
        /// </summary>
        private const string GradeD = "/Studentlist/Student[@grade='D']";
        /// <summary>
        /// print students 
        /// </summary>
        private const string PrintStudents = "{0}\n";
        /// <summary>
        /// file name of the xml file
        /// </summary>
        private const string FileName="/Students.xml";
        /// <summary>
        /// path of the file
        /// </summary>
        private string FilePath = string.Format("{0}{1}", HttpContext.Current.Request.PhysicalApplicationPath, FileName);

        ///object of XmlDocument to load the file
        XmlDocument xml = new XmlDocument();

        /// <summary>
        /// method to return all the student with branch as MCA
        /// </summary>
        /// <param name="path">path of the xml file</param>
        /// <returns>name of the students</returns>

        public string GetMCAStudent()
        {
            ///string to save names
            string StudentName = string.Empty;

            ///load xml file
            xml.Load(FilePath);

            ///select nodes having branch as MCA
            XmlNodeList xmlNodeList = xml.SelectNodes(MCAStudents);
            ///print all the students
            foreach (XmlNode student in xmlNodeList)
            {
                StudentName += String.Format(PrintStudents, student.InnerText); 
            }
            ///return the names of students
            return StudentName;
        }

        /// <summary>
        /// Print Student with D Grade
        /// </summary>
        /// <returns></returns>
        public string GetStudentWithDGrade()
        {
            ///string to return names
            string StudentName = string.Empty;
            ///load xml file

            xml.Load(FilePath);
            ///select students having D grade
            XmlNodeList xmlNodeList = xml.SelectNodes(GradeD);
            ///print all the students
            foreach (XmlNode student in xmlNodeList)
            {
                StudentName = String.Format(PrintStudents, student.InnerText); 
            }
            ///return the names of students
            return StudentName;
        }

       
    }
}
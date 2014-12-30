using System.Collections.Generic;
using System.Xml;

namespace Assignment29
{
   /// <summary>
   /// student class
   /// </summary>
    public class Students
    {
        /// <summary>
        /// string to contain file path
        /// </summary>
        private const string FilePath = "Students.xml";
        /// <summary>
        /// get node having stream as pcm
        /// </summary>
        private const string GetNode = "Students/Student/Stream[text()='PCM']";

        /// <summary>
        /// name of the new node
        /// </summary>
        private const string CollegeNode = "College";

        /// <summary>
        /// inner text of new node
        /// </summary>
        private const string InnerText = "Engineering";
        /// <summary>
        /// get all the student nodes from xml
        /// </summary>
        private const string StudentList = "/Students/Student";       
        private const string NameAttribute = "name";
        private const string AgeAttribute = "age";
        private const string StreamNode = "Stream";
        private const string AddressNode = "Address";
        private const string CountryNode = "Address/Country";
        private const string CityNode = "Address/City";
        /// <summary>
        /// Student's name
        /// </summary>
        public string StudentName;
        /// <summary>
        /// Studnet's age
        /// </summary>
        public int StudentAge;
        /// <summary>
        /// Student's stream
        /// </summary>
        public string Stream;
        /// <summary>
        /// student's address
        /// </summary>
        public string Address;
        /// <summary>
        /// student's country
        /// </summary>
        public string Country;
        /// <summary>
        /// student's city
        /// </summary>
        public string City;

        /// <summary>
        /// methos to get students objects
        /// </summary>
        /// <returns>List of student objects</returns>
        public List<Students> GetStudent()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FilePath);

            XmlNodeList nodes = doc.DocumentElement.SelectNodes(StudentList);

            List<Students> students = new List<Students>();

            foreach (XmlNode node in nodes)
            {
                
                Students student = new Students();
                student.StudentName = node.Attributes[NameAttribute].Value;
                student.StudentAge = int.Parse(node.Attributes[AgeAttribute].Value);
                student.Stream = node.SelectSingleNode(StreamNode).InnerText;
                student.Address = node.SelectSingleNode(AddressNode).InnerText;
                student.Country = node.SelectSingleNode(CountryNode).InnerText;
                student.City = node.SelectSingleNode(CityNode).InnerText;
                
                students.Add(student);
            }

            return students;

        }
        /// <summary>
        /// methos to append a child where stream is PCM
        /// </summary>
        public void AppendChild()
        {
             XmlDocument doc = new XmlDocument();
             doc.Load(FilePath);

             //create the object of XmlNodeList to contain the list of nodes
             XmlNodeList nodeList = doc.SelectNodes(GetNode);
            foreach (XmlNode xn in nodeList)
            {
                XmlElement xmlNewNode = doc.CreateElement(CollegeNode);
                xmlNewNode.InnerText = InnerText;

                xn.AppendChild(xmlNewNode);
                doc.Save(FilePath);
           
            }

            
                        
        }
    }
}
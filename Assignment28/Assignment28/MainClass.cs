using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace Assignment28
{
    /// <summary>
    /// main class which will Serialize and Deserialize the objects collections
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Strings used in the program
        /// </summary>

        private const string DatLocation = "/SerializationData/iCalibrator.dat";
        private const string XmlLocation = "/SerializationData/iCalibrator.xml";
        private const string SoapLocation = "/SerializationData/iCalibrator.soap";
        private const string BeforeBinarySerialization ="Object's state before Binary Serialization";
        private const string AfterBinaryDeSerialization ="Object's state after Binary DeSerialization";
        private const string BeforeXmlSerialization ="Object's state before Xml Serialization";
        private const string AfterXmlDeSerialization ="Object's state after Xml DeSerialization";
        private const string BeforeSoapSerialization ="Object's state before Soap Serialization";
        private const string AfterSoapDeSerialization ="Object's state after Soap DeSerialization";
        private const string Name ="Name: {0}";
        private const string RollNo ="RollNo: {0}";
        private const string TotalMarks = "TotalMarks: {0}";
        private const string Grade = "Grade: {0}";
        private const string StudentName1 = "Sheenu";
        private const string StudentName2 = "Shilpi";

        static void Main(string[] args)
        {
            ///binary Serialization 

            List<Student> binaryList = new List<Student>();
            binaryList.Add(new Student(StudentName1, 3,97));
            binaryList.Add(new Student(StudentName2, 9, 96));

            Console.WriteLine(BeforeBinarySerialization);
            // Object's state before serilization
            foreach (var item in binaryList)
            {
            Console.WriteLine(Name, item.Name);
            Console.WriteLine(RollNo, item.RollNo);
            Console.WriteLine(TotalMarks, item.TotalMarks);
            Console.WriteLine(Grade, item.Grade);
            }
           
            /// Serialization Object
            IFormatter binaryFormatter = new BinaryFormatter();
            Stream binaryStream = new FileStream(DatLocation, FileMode.Create, FileAccess.Write, FileShare.None);
            binaryFormatter.Serialize(binaryStream, binaryList);
            binaryStream.Close();

            /// DeSerialization Object
            IFormatter binaryFormatter1 = new BinaryFormatter();
            Stream binaryStream1 = new FileStream(DatLocation, FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Student> binaryList1 = (List<Student>)binaryFormatter1.Deserialize(binaryStream1);
            binaryStream1.Close();

            Console.WriteLine(AfterBinaryDeSerialization);
            // Object's filelds after deserializing the serialized data
            foreach (var item in binaryList1)
            {
                Console.WriteLine(Name, item.Name);
                Console.WriteLine(RollNo, item.RollNo);
                Console.WriteLine(TotalMarks, item.TotalMarks);
                Console.WriteLine(Grade, item.Grade);
            }

            ///xml serialization 

            List<Student> xmlList = new List<Student>();
            xmlList.Add(new Student(StudentName1, 3, 97));
            xmlList.Add(new Student(StudentName2, 9, 96));
            Console.WriteLine(BeforeXmlSerialization);
            // Object's state before serialized data
            foreach (var item in xmlList)
            {
            Console.WriteLine(Name, item.Name);
            Console.WriteLine(RollNo, item.RollNo);
            Console.WriteLine(TotalMarks, item.TotalMarks);
            Console.WriteLine(Grade, item.Grade);
            }


            /// Serialization Object

            // Create and instance of XmlSerializer class. 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            // Create an instance of stream writer.
            TextWriter txtWriter = new StreamWriter(XmlLocation);
            // Serialize the instance of BasicSerialization
            xmlSerializer.Serialize(txtWriter, xmlList);
            // Close the stream writer
            txtWriter.Close();

            ///DeSerialization Object

            XmlSerializer deserializer = new XmlSerializer(typeof(List<Student>));
            TextReader reader = new StreamReader(XmlLocation);
            List<Student> xmlList1 = (List<Student>)deserializer.Deserialize(reader);

            Console.WriteLine(AfterXmlDeSerialization);
            // Object's filelds after deserializing the serialized data
            foreach (var item in xmlList1)
            {
                Console.WriteLine(Name, item.Name);
                Console.WriteLine(RollNo, item.RollNo);
                Console.WriteLine(TotalMarks, item.TotalMarks);
                Console.WriteLine(Grade, item.Grade);
            }



            ///Soap serilization 

            List<Student> soapList = new List<Student>();
            soapList.Add(new Student(StudentName1, 3, 97));
            soapList.Add(new Student(StudentName2, 9, 96));

            Console.WriteLine(BeforeSoapSerialization);
            // Object's state before serilization
            foreach (var item in soapList)
            {
                Console.WriteLine(Name, item.Name);
                Console.WriteLine(RollNo, item.RollNo);
                Console.WriteLine(TotalMarks, item.TotalMarks);
                Console.WriteLine(Grade, item.Grade);
            }

            ///Serialization Object

            IFormatter SoapFormatter = new SoapFormatter();
            Stream soapStream = new FileStream(SoapLocation, FileMode.Create, FileAccess.Write, FileShare.None);
            SoapFormatter.Serialize(soapStream, soapList);
            soapStream.Close();

            ///DeSerialization Object
            IFormatter SoapFormatter1 = new SoapFormatter();
            Stream soapStream1 = new FileStream(SoapLocation, FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Student> soapList1 = (List<Student>)SoapFormatter1.Deserialize(soapStream);
            soapStream.Close();

            Console.WriteLine(AfterSoapDeSerialization);
            // Object's filelds after deserializing the serialized data
            foreach (var item in soapList1)
            {
                Console.WriteLine(Name, item.Name);
                Console.WriteLine(RollNo, item.RollNo);
                Console.WriteLine(TotalMarks, item.TotalMarks);
                Console.WriteLine(Grade, item.Grade);
            }
            Console.ReadLine();

        }
    }
}

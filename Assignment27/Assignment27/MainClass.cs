using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace Assignment27
{
    /// <summary>
    /// main class which will Serialize and Deserializeobjects
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// strings used in class
        /// </summary>
        private const string DatLocation = @"SerializationData\iCalibrator.dat";
        private const string XmlLocation = @"SerializationData\iCalibrator.xml";
        private const string SoapLocation = @"SerializationData\iCalibrator.soap"; 
        private const string BeforeBinarySerialization = "Object's state before Binary Serialization";
        private const string AfterBinaryDeSerialization ="Object's state after Binary DeSerialization";
        private const string BeforeXmlSerialization ="Object's state before Xml Serialization";
        private const string AfterXmlDeSerialization ="Object's state after Xml DeSerialization";
        private const string BeforeSoapSerialization ="Object's state before Soap Serialization";
        private const string AfterSoapDeSerialization ="Object's state after Soap DeSerialization";
        private const string Name ="Name: {0}";
        private const string RollNo ="RollNo: {0}";
        private const string TotalMarks = "TotalMarks: {0}";
        private const string Grade = "Grade: {0}";
        private const string StudentName = "Sheenu";

        static void Main(string[] args)
        {
            ///binary Serialization 

            Student objBinary = new Student(StudentName, 03, 98);

            Console.WriteLine(BeforeBinarySerialization);
            // Object's state before serilization
            Console.WriteLine(Name, objBinary.Name);
            Console.WriteLine(RollNo, objBinary.RollNo);
            Console.WriteLine(TotalMarks, objBinary.TotalMarks);
            Console.WriteLine(Grade, objBinary.Grade);

            /// Serialization Object
            IFormatter binaryFormatter = new BinaryFormatter();
            Stream binaryStream = new FileStream(DatLocation, FileMode.Create, FileAccess.Write, FileShare.None);
            binaryFormatter.Serialize(binaryStream, objBinary);
            binaryStream.Close();

            /// DeSerialization Object
            IFormatter binaryFormatter1 = new BinaryFormatter();
            Stream binaryStream1 = new FileStream(DatLocation, FileMode.Open, FileAccess.Read, FileShare.Read);
            Student objBinary1 = (Student)binaryFormatter1.Deserialize(binaryStream1);
            binaryStream1.Close();

            Console.WriteLine(AfterBinaryDeSerialization);
            // Object's filelds after deserializing the serialized data
            Console.WriteLine(Name, objBinary1.Name);
            Console.WriteLine(RollNo, objBinary1.RollNo);
            Console.WriteLine(TotalMarks, objBinary1.TotalMarks);
            Console.WriteLine(Grade, objBinary1.Grade);

            ///xml serialization 
            
            Student xmlStudent = new Student(StudentName, 03, 98);
            Console.WriteLine(BeforeXmlSerialization);
            // Object's filelds after deserializing the serialized data
            Console.WriteLine(Name, xmlStudent.Name);
            Console.WriteLine(RollNo, xmlStudent.RollNo);
            Console.WriteLine(TotalMarks, xmlStudent.TotalMarks);
            Console.WriteLine(Grade, xmlStudent.Grade);

            
            /// Serialization Object
        
            // Create and instance of XmlSerializer class. 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            // Create an instance of stream writer.
            TextWriter txtWriter = new StreamWriter(XmlLocation);
            // Serialize the instance of BasicSerialization
            xmlSerializer.Serialize(txtWriter, xmlStudent);
            // Close the stream writer
            txtWriter.Close();
            
            ///DeSerialization Object
                      
            XmlSerializer deserializer = new XmlSerializer(typeof(Student));
            TextReader reader = new StreamReader(XmlLocation);
            Student xmlStudent1 = (Student)deserializer.Deserialize(reader);

            Console.WriteLine(AfterXmlDeSerialization);
            // Object's filelds after deserializing the serialized data
             Console.WriteLine(Name, xmlStudent1.Name);
             Console.WriteLine(RollNo, xmlStudent1.RollNo);
             Console.WriteLine(TotalMarks, xmlStudent1.TotalMarks);
             Console.WriteLine(Grade, xmlStudent1.Grade);



              ///Soap serilization 

             Student objSoap = new Student(StudentName, 03, 98);

             Console.WriteLine(BeforeSoapSerialization);
            // Object's state before serilization
             Console.WriteLine(Name, objSoap.Name);
             Console.WriteLine(RollNo, objSoap.RollNo);
             Console.WriteLine(TotalMarks, objSoap.TotalMarks);
             Console.WriteLine(Grade, objSoap.Grade);

             ///Serialization Object
             
            IFormatter SoapFormatter = new SoapFormatter();
            Stream soapStream = new FileStream(SoapLocation, FileMode.Create, FileAccess.Write, FileShare.None);
            SoapFormatter.Serialize(soapStream, objSoap);
            soapStream.Close();

            ///DeSerialization Object
            IFormatter SoapFormatter1 = new SoapFormatter();
            Stream soapStream1 = new FileStream(SoapLocation, FileMode.Open, FileAccess.Read, FileShare.Read);
            Student objSoap1 = (Student)SoapFormatter1.Deserialize(soapStream);
            soapStream.Close();

            Console.WriteLine(AfterSoapDeSerialization);
            // Object's filelds after deserializing the serialized data
            Console.WriteLine(Name, objSoap1.Name);
            Console.WriteLine(RollNo, objSoap1.RollNo);
            Console.WriteLine(TotalMarks, objSoap1.TotalMarks);
            Console.WriteLine(Grade, objSoap1.Grade);
           
            Console.ReadLine();

        }
    }
}

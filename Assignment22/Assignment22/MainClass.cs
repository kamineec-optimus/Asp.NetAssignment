using System.IO;
using System;

namespace Assignment22
{
    
    class MainClass
    {
        /// <summary>
        /// string used in the program
        /// </summary>
        private const string FilePath = @"E:\New folder";    
        private const string String_Data = "I am happy";
        private const string CreateDisable = "{0} \n Cannot create file.";
        private const string WriteDisable = "{0} \n Cannot write to file.";
        private const string OpenDisable = "{0} \n Cannot open file.";
        private const string ReadDisable = "{0} \n Cannot read file.";
        private const string ReadIntData = "Integer data: {0}";
        private const string ReadDoubleData = "Double data: {0}";
        private const string ReadBooleanData = "Boolean data: {0}";
        private const string ReadStringData = "String data: {0}";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ///call method to do the read/write/create file
            WriteReadBinary();
            Console.ReadLine();
        }
       
        /// <summary>
        /// method to read and write file by using BinaryReader and BinaryWriter
        /// </summary>
        public static void WriteReadBinary()
        {
            ///fine name to be created and path where file will be created
            string fileName3 = FilePath;
            /// objects of  BinaryWriter,BinaryReader
            BinaryWriter binaryWriter;
            BinaryReader binaryReader;

            int intData = 25; ///int data to be write/read from file
            double doubleData = 3.14157; ///double data to be write/read from file
            bool boolData = true; ///bool data to be write/read from file
            string stringData = String_Data; ///string data to be write/read from file

            //create the file
            try
            {
                binaryWriter = new BinaryWriter(new FileStream(fileName3,FileMode.Create));
            }
              ///exception to handle if file can not be created
            catch (IOException e)
            {
                
                Console.WriteLine(CreateDisable, e.Message);
                return;
            }
            //writing to the file created
            try
            {
                binaryWriter.Write(intData);
                binaryWriter.Write(doubleData);
                binaryWriter.Write(boolData);
                binaryWriter.Write(stringData);
            }

            catch (IOException e)
            {
                Console.WriteLine(CreateDisable, e.Message);
                return;
            }

            finally
            {
                ///close the object once writing to the file is completed
                binaryWriter.Close();
            }
            //reading from the file
            try
            {
                binaryReader = new BinaryReader(new FileStream(fileName3,FileMode.Open));
            }
            catch (IOException e)
            {
                             
                Console.WriteLine(OpenDisable,e.Message);
               
                return;
            }

            ///print data from the file
            try
            {
                intData = binaryReader.ReadInt32();
                Console.WriteLine(ReadIntData, intData);
                doubleData = binaryReader.ReadDouble();
                Console.WriteLine(ReadDoubleData, doubleData);
                boolData = binaryReader.ReadBoolean();
                Console.WriteLine(ReadBooleanData, boolData);
                stringData = binaryReader.ReadString();
                Console.WriteLine(ReadStringData, stringData);
            }
            catch (IOException e)
            {
                Console.WriteLine(ReadDisable, e.Message);
                return;
            }
            ///close the object once reading from the file is completed
            finally
            {
                binaryReader.Close();
            }
            Console.ReadKey();
        }

    }
}